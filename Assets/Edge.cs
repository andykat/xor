using UnityEngine;
using System.Collections;

public class Edge{
	public Neuron neuron;
	public double weight;
	public Edge(Neuron tNeuron, double tWeight){
		neuron = tNeuron;
		weight = tWeight;
	}
}
