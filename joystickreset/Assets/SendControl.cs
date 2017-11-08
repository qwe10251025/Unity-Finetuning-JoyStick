using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendControl : MonoBehaviour {

	public GameObject blackview;

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
		blackview.SetActive(true);

		startbut.enabled = true;
		startimg.enabled = true;
		txt.enabled = true;

	}
	public void Startmission(){

		switch (missionnum){

		case 0:
			
			blackview.SetActive (false);

			mission1.SetActive (true);
			god0box.enabled = true;
			god0line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 0;
			taskstatus = true;


			oscSender.setOSCData (0, 1, 0f, 0f, 0f, 0f, 0f);
			oscSender.MySendOSCMessageTriggerMethod ();

			break;

		case 1:

			blackview.SetActive (false);

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			mission2.SetActive (true);
			god15box.enabled = true;
			god15line.enabled = true;

			missionnum = 1;
			taskstatus = true;

			oscSender.setOSCData (1, 1, 0f, 0f, 0f, 0f, 0f);
			oscSender.MySendOSCMessageTriggerMethod ();

			break;

		case 2:

			blackview.SetActive(false);

			mission3.SetActive(true);
			ship30box.enabled = true;
			ship30line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 2;
			taskstatus = true;

			oscSender.setOSCData (2,1,0f,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();


			break;

		case 3:

			blackview.SetActive(false);

			mission4.SetActive(true);
			ship45box.enabled = true;
			ship45line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 3;
			taskstatus = true;

			oscSender.setOSCData (3,1,0f,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();
			break;

		case 4:

			blackview.SetActive(false);

			mission5.SetActive(true);
			car60box.enabled = true;
			car60line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 4;
			taskstatus = true;

			oscSender.setOSCData (4,1,0f,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();
			break;

		case 5:
			blackview.SetActive(false);

			mission6.SetActive(true);
			car75box.enabled = true;
			car75line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 5;
			taskstatus = true;

			oscSender.setOSCData (5,1,0f,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();
			break;

		case 6:

			blackview.SetActive(false);

			mission7.SetActive(true);
			ship90box.enabled = true;
			ship90line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 6;
			taskstatus = true;

			oscSender.setOSCData (6,1,0f,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();

			break;
		
		}
	}

	public void snap(){

		switch (missionnum) {

		case 0:

			if (taskstatus == true) {

				blackview.SetActive (true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;

				mission1.SetActive (false);
				god0box.enabled = false;
				god0line.enabled = false;



				oscSender.setOSCData (0, 0, mission1.transform.position.x, mission1.transform.position.y, mission1.transform.position.z, mission1.transform.rotation.eulerAngles.y, cam1.transform.rotation.eulerAngles.x);

				Debug.Log (mission1.transform.position.x + "," + mission1.transform.position.y + "," + mission1.transform.position.z + "," + mission1.transform.rotation.eulerAngles.y + "," + cam1.transform.rotation.eulerAngles.x);

				oscSender.MySendOSCMessageTriggerMethod ();	
				taskstatus = false;
				missionnum = 1;
			}
			
//			else if (taskstatus == false) {
//
//				blackview.SetActive(false);
//
//
//				mission2.SetActive(true);
//				god15box.enabled = true;
//				god15line.enabled = true;
//
//				missionnum = 1;
//				taskstatus = true;
//
//				oscSender.setOSCData (1,1,0f,0f,0f,0f,0f);
//				oscSender.MySendOSCMessageTriggerMethod();
//			}

			break;

		case 1:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;

				mission2.SetActive(false);
				god15box.enabled = false;
				god15line.enabled = false;

				missionnum = 2;


				oscSender.setOSCData (1,0,mission2.transform.position.x,mission2.transform.position.y,mission2.transform.position.z,mission2.transform.rotation.eulerAngles.y,cam2.transform.rotation.eulerAngles.x);
				oscSender.MySendOSCMessageTriggerMethod();	
				taskstatus = false;
			}
//			else if (taskstatus == false) {
//
//				blackview.SetActive(false);
//
//				mission3.SetActive(true);
//				ship30box.enabled = true;
//				ship30line.enabled = true;
//
//				missionnum = 2;
//				taskstatus = true;
//
//				oscSender.setOSCData (2,1,0f,0f,0f,0f,0f);
//				oscSender.MySendOSCMessageTriggerMethod();
//			}

			break;

		case 2:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;

				mission3.SetActive(false);
				ship30box.enabled = false;
				ship30line.enabled = false;

				missionnum = 3;


				oscSender.setOSCData (2,0,mission3.transform.position.x,mission3.transform.position.y,mission3.transform.position.z,mission3.transform.rotation.eulerAngles.y,cam3.transform.rotation.eulerAngles.x);
				oscSender.MySendOSCMessageTriggerMethod();	
				taskstatus = false;
			}
//			else if (taskstatus == false) {
//
//				blackview.SetActive(false);
//
//				mission4.SetActive(true);
//				ship45box.enabled = true;
//				ship45line.enabled = true;
//
//				missionnum = 3;
//				taskstatus = true;
//
//				oscSender.setOSCData (3,1,0f,0f,0f,0f,0f);
//				oscSender.MySendOSCMessageTriggerMethod();
//			}

			break;

		case 3:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;

				mission4.SetActive(false);
				ship45box.enabled = false;
				ship45line.enabled = false;

				missionnum = 4;


				oscSender.setOSCData (3,0,mission4.transform.position.x,mission4.transform.position.y,mission4.transform.position.z,mission4.transform.rotation.eulerAngles.y,cam4.transform.rotation.eulerAngles.x);
				oscSender.MySendOSCMessageTriggerMethod();	
				taskstatus = false;
			}
//			else if (taskstatus == false) {
//
//				blackview.SetActive(false);
//
//				mission5.SetActive(true);
//				car60box.enabled = true;
//				car60line.enabled = true;
//
//				missionnum = 4;
//				taskstatus = true;
//
//				oscSender.setOSCData (4,1,0f,0f,0f,0f,0f);
//				oscSender.MySendOSCMessageTriggerMethod();
//			}

			break;

		case 4:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;

				mission5.SetActive(false);
				car60box.enabled = false;
				car60line.enabled = false;

				missionnum = 5;


				oscSender.setOSCData (4,0,mission5.transform.position.x,mission5.transform.position.y,mission5.transform.position.z,mission5.transform.rotation.eulerAngles.y,cam5.transform.rotation.eulerAngles.x);
				oscSender.MySendOSCMessageTriggerMethod();	
				taskstatus = false;
			}
//			else if (taskstatus == false) {
//
//				blackview.SetActive(false);
//
//				mission6.SetActive(true);
//				car75box.enabled = true;
//				car75line.enabled = true;
//
//				missionnum = 5;
//				taskstatus = true;
//
//				oscSender.setOSCData (5,1,0f,0f,0f,0f,0f);
//				oscSender.MySendOSCMessageTriggerMethod();
//			}

			break;

		case 5:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;

				mission6.SetActive(false);
				car75box.enabled = false;
				car75line.enabled = false;

				missionnum = 6;


				oscSender.setOSCData (5,0,mission6.transform.position.x,mission6.transform.position.y,mission6.transform.position.z,mission6.transform.rotation.eulerAngles.y,cam6.transform.rotation.eulerAngles.x);
				oscSender.MySendOSCMessageTriggerMethod();	
				taskstatus = false;
			}
//			else if (taskstatus == false) {
//
//				blackview.SetActive(false);
//
//				mission7.SetActive(true);
//				ship90box.enabled = true;
//				ship90line.enabled = true;
//
//				missionnum = 6;
//				taskstatus = true;
//
//				oscSender.setOSCData (6,1,0f,0f,0f,0f,0f);
//				oscSender.MySendOSCMessageTriggerMethod();
//			}

			break;
		
		case 6:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;

				mission7.SetActive(false);
				ship90box.enabled = false;
				ship90line.enabled = false;



				oscSender.setOSCData (6,0,mission7.transform.position.x,mission7.transform.position.y,mission7.transform.position.z,mission7.transform.rotation.eulerAngles.y,cam7.transform.rotation.eulerAngles.x);
				oscSender.MySendOSCMessageTriggerMethod();	
				taskstatus = false;
			}

			break;
		}





	
	}

}
