﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Nucleon : MonoBehaviour {
    public float attractionForce;
    Rigidbody body;

	private void Awake()
	{
        body = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
        body.AddForce(transform.localPosition * -attractionForce);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
