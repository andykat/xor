using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Neuron {
	public List<Edge> inputEdges;
	public double value;
	public Neuron()
	{
		inputEdges = new List<Edge> ();
		value = 0.0f;
	}
	public void addInput(Edge e)
	{
		inputEdges.Add (e);
	}
	public void computeValue()
	{
		//calculate weighted sum
		double z = 0.0f;
		for(int i=0;i<inputEdges.Count;i++){
			z += inputEdges[i].neuron.value * inputEdges[i].weight;
		}
		double e2z = Math.Pow (Math.E, 2.0 * z);
		value = (e2z - 1) / (e2z + 1);
	}
}
