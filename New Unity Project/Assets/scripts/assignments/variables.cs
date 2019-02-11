using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour {
//variables 
	public static int number;  
	public float speed;
	public string name;

	// Use this for initialization
	void Start () {
		number = 10;
	/*
	this
	is
	a
	multiline
	comment 
	*/
		speed = 0.94f;
		name = "Bob";

		print(name +" is "+ number+"years old"+ speed);
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(number,0,0);

	}
}
