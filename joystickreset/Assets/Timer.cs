using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour {


	private float temp; 
	public int tm;
	public int ts;
	public float tms;
	public string timerText; 

	public bool status;
	// Use this for initialization
	void Start () {
		status = false;
	}

	// Update is called once per frame
	void Update () {

		Debug.Log ("ts" + ts);

		if (status == true) {
			temp += Time.deltaTime;
			//
			//			TimeSpan timeSpan = TimeSpan.FromMilliseconds(temp); 
			//
			TimeSpan timeSpan1 = TimeSpan.FromSeconds (temp); 
			//			//TimeSpan timeSpan2 = TimeSpan.FromMilliseconds (temp); 
			//
			//			tm = timeSpan.Minutes;
			ts = timeSpan1.Seconds;
			//			tms = timeSpan.Milliseconds;
			//
			//Debug.Log ("ts" + ts);



//			temp += Time.deltaTime; //#3
//			TimeSpan timeSpan = TimeSpan.FromSeconds(temp); //#4
//
//			timerText = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Minutes, timeSpan.Seconds,timeSpan.Milliseconds); //#5

		} else {
			ts = 0;
			temp = 0;		
		}
	}
}