﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}
		if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

	}
}
