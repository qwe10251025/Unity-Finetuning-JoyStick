using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendControl : MonoBehaviour {

	public Camera blackview;

	public GameObject mission1;
	public Camera cam1;
	public GameObject mission2;
	public Camera cam2;

	public GameObject mission3;
	public Camera cam3;

	public GameObject mission4;
	public Camera cam4;

	public GameObject mission5;
	public Camera cam5;

	public GameObject mission6;
	public Camera cam6;

	public GameObject mission7;
	public Camera cam7;

	public RawImage god0box;
	public RawImage god0line;

	public RawImage god15box;
	public RawImage god15line;

	public RawImage ship30box;
	public RawImage ship30line;

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

	private bool taskstatus;

	private int missionnum;

	public OSCSender oscSender;

	void Start(){

		//true = snap button can send data 
		taskstatus = true;

		startbut.enabled = true;
		startimg.enabled = true;
		txt.enabled = true;

	}
	public void Startmission(){

		mission1.SetActive(true);
		god0box.enabled = true;
		god0line.enabled = true;

		startbut.enabled = false;
		startimg.enabled = false;
		txt.enabled = false;

		missionnum = 0;

		oscSender.setOSCData (0,1,0f,0f,0f,0f,0f);
		oscSender.MySendOSCMessageTriggerMethod();
	}

	public void snap(){

		switch (missionnum) {

		case 0:

			if (taskstatus == true) {


				mission1.SetActive(false);
				god0box.enabled = false;
				god0line.enabled = false;



				oscSender.setOSCData (0,0,mission1.transform.position.x,mission1.transform.position.y,mission1.transform.position.z,mission1.transform.rotation.eulerAngles.y,cam1.transform.rotation.eulerAngles.x);
				oscSender.MySendOSCMessageTriggerMethod();	
				taskstatus = false;
			}else if (taskstatus == false) {

				mission2.SetActive(true);
				god15box.enabled = true;
				god15line.enabled = true;

				missionnum = 1;
				taskstatus = true;

				oscSender.setOSCData (1,1,0f,0f,0f,0f,0f);
				oscSender.MySendOSCMessageTriggerMethod();
			}

			break;

		case 1:

			if (taskstatus == true) {


				mission2.SetActive(false);
				god15box.enabled = false;
				god15line.enabled = false;



				oscSender.setOSCData (1,0,mission2.transform.position.x,mission2.transform.position.y,mission2.transform.position.z,mission2.transform.rotation.eulerAngles.y,cam2.transform.rotation.eulerAngles.x);
				oscSender.MySendOSCMessageTriggerMethod();	
				taskstatus = false;
			}else if (taskstatus == false) {

				mission3.SetActive(true);
				ship30box.enabled = true;
				ship30line.enabled = true;

				missionnum = 2;
				taskstatus = true;

				oscSender.setOSCData (2,1,0f,0f,0f,0f,0f);
				oscSender.MySendOSCMessageTriggerMethod();
			}

			break;
	

		}





	
	}

}
