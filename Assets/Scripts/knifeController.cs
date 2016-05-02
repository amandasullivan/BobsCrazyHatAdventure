﻿using UnityEngine;
using System.Collections;

public class knifeController : MonoBehaviour {

	public float knifeSpeed;

	Rigidbody2D myRB;
	// Use this for initialization

	void Awake () {
		myRB = GetComponent<Rigidbody2D> ();


		if(transform.localRotation.z>0)
		myRB.AddForce (new Vector2 (-1, 0) * knifeSpeed, ForceMode2D.Impulse);
		else myRB.AddForce (new Vector2 (1, 0) * knifeSpeed, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void removeForce(){
		myRB.velocity = new Vector2 (0, 0);
	}
}