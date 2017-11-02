using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerPeople : MonoBehaviour {


	public static bool tri = false;
	public Text showtext;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(){

		tri = true;
		showtext.color = Color.red;
		showtext.text = "TooClose";
	}

	public void OnTriggerExit(){

		tri = false;
		showtext.text = "";

	}


}
