using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {


	public static float x = 0;
	public static float y = 0;
	public static float z = 0;

	// Use this for initialization
	void Start () {

		x = 0;
		y = 0;
		z = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Up(){

		x = -0.5f;
	}

	public void Upf(){

		x = 0;

	}

	public void Down(){

		x = 0.5f;
	}

	public void Downf(){

		x = 0;
	}



}







