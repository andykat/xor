using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Network {
	public List<Neuron> neurons;
	public List<int> inputNeuronIndexes;
	public List<int> outputNeuronIndexes;

	public Network(){

	}

	public void addNeuron(Neuron n){
		neurons.Add (n);
	}
	public void addInput(int index){
		inputNeuronIndexes.Add (index);
	}
	public void addOutput(int index){
		outputNeuronIndexes.Add (index);
	}	
}
