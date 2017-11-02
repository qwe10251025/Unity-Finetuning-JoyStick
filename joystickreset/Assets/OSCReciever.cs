using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniOSC;
using OSCsharp.Data;
using UnityEngine.UI;

public class OSCReciever : UniOSCEventTarget {


	public GameObject plane;
	public GameObject people;
	public Camera cam;


	public GameObject mission1;
	public GameObject mission2;

	public GameObject mission3;

	public GameObject mission4;

	public GameObject mission5;
	public GameObject mission6;
	public GameObject mission7;

	public RawImage god0box;
	public RawImage god0line;

	public RawImage god15box;
	public RawImage god15line;

	public RawImage god30box;
	public RawImage god30line;

	public RawImage ship45box;
	public RawImage ship45line;

	public RawImage car60box;
	public RawImage car60line;

	public RawImage car75box;
	public RawImage car75line;

	public RawImage ship90box;
	public RawImage ship90line;

	public Button startbut;
	public Image startimg;
	public Text txt;


	public void Startmission(){
	
		mission1.SetActive(true);
		god0box.enabled = true;
		god0line.enabled = true;
		startbut.enabled = false;
		startimg.enabled = false;
		txt.enabled = false;
	}

	public override void OnOSCMessageReceived(UniOSCEventArgs args){


		OscMessage msg = (OscMessage)args.Packet; 
		if (msg.Data.Count < 1)
			return;



		int Joycommand = (int)msg.Data[0];
		float Joyvalue = (float)msg.Data[1];


	



  }
}
