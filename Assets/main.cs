using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class main : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private double fitness(double input, double output)
	{
		return 1.0 / (1.0 + Math.Abs (input - output));
	}
}
