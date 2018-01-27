using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using OSCsharp.Data;

public class SendControl : MonoBehaviour {

	public GameObject blackview;

	public GameObject mission1;
	public GameObject mission2;
	public GameObject mission3;
	public GameObject mission4;
	public GameObject mission5;
	public GameObject mission6;
	public GameObject mission7;

	public GameObject mission8;
	public GameObject mission9;
	public GameObject mission10;
	public GameObject mission11;
	public GameObject mission12;
	public GameObject mission13;
	public GameObject mission14;





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



	public RawImage blowing0box;
	public RawImage blowing0line;
	public RawImage blowing15box;
	public RawImage blowing15line;
	public RawImage bus30box;
	public RawImage bus30line;
	public RawImage bus45box;
	public RawImage bus45line;
	public RawImage boat60box;
	public RawImage boat60line;
	public RawImage boat75box;
	public RawImage boat75line;
	public RawImage bus90box;
	public RawImage bus90line;

	public Button snapbut;
	public Image snapimg;
	public Text snaptxt;


	public Button startbut;
	public Image startimg;
	public Text txt;

	private Control distance1;
	private Control distance2;
	private Control distance3;
	private Control distance4;
	private Control distance5;
	private Control distance6;
	private Control distance7;


	private Control distance8;
	private Control distance9;
	private Control distance10;
	private Control distance11;
	private Control distance12;
	private Control distance13;
	private Control distance14;

	private bool taskstatus;

	private int missionnum;

	public Timer time;

	public OSCSender oscSender;

	void Start(){
		//mission0LookAns
		//true = snap button can send data 
		taskstatus = true;
		blackview.SetActive(true);

		startbut.enabled = true;
		startimg.enabled = true;
		txt.enabled = true;

		snapbut.enabled = false;
		snapimg.enabled = false;
		snaptxt.enabled = false;
	}

	void Update(){

		distance1 = mission1.GetComponent<Control> ();
		distance2 = mission2.GetComponent<Control> ();
		distance3 = mission3.GetComponent<Control> ();
		distance4 = mission4.GetComponent<Control> ();
		distance5 = mission5.GetComponent<Control> ();
		distance6 = mission6.GetComponent<Control> ();
		distance7 = mission7.GetComponent<Control> ();

		distance8 = mission8.GetComponent<Control> ();
		distance9 = mission9.GetComponent<Control> ();
		distance10 = mission10.GetComponent<Control> ();
		distance11 = mission11.GetComponent<Control> ();
		distance12 = mission12.GetComponent<Control> ();
		distance13 = mission13.GetComponent<Control> ();
		distance14= mission14.GetComponent<Control> ();



		if(distance1.distance< distance1.range && mission1.activeInHierarchy == true){

			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;

			oscSender.setOSCData (0, 0, mission1.transform.position.x, mission1.transform.position.y, mission1.transform.position.z, mission1.transform.rotation.eulerAngles.y);

			oscSender.MySendOSCMessageTriggerMethod ();	


			distance1.raw.color = new Color (0f, 255f, 0f);

			// if(time.ts > 5){
			// 	time.status = false;
			// 	snap ();
			// }


		}else if(distance1.distance >distance1.range && mission1.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance1.raw.color = new Color (255f, 0f, 0f);
		
		}
		if(distance2.distance < distance2.range && mission2.activeInHierarchy == true){

			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;

			oscSender.setOSCData (1,0,mission2.transform.position.x,mission2.transform.position.y,mission2.transform.position.z,mission2.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	

			distance2.raw.color = new Color (0f, 255f, 0f);

		

		}else if(distance2.distance >distance2.range && mission2.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance2.raw.color = new Color (255f, 0f, 0f);
		
		}
		if(distance3.distance<distance3.range && mission3.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (2,0,mission3.transform.position.x,mission3.transform.position.y,mission3.transform.position.z,mission3.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	

			distance3.raw.color = new Color (0f, 255f, 0f);

			
		}else if(distance3.distance >distance3.range && mission3.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance3.raw.color = new Color (255f, 0f, 0f);
		
		}
		if(distance4.distance<distance4.range && mission4.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (3,0,mission4.transform.position.x,mission4.transform.position.y,mission4.transform.position.z,mission4.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	

			distance4.raw.color = new Color (0f, 255f, 0f);

			
			
		}else if(distance4.distance >distance4.range && mission4.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance4.raw.color = new Color (255f, 0f, 0f);
		
		}
		if(distance5.distance<distance5.range && mission5.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (4,0,mission5.transform.position.x,mission5.transform.position.y,mission5.transform.position.z,mission5.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	

			distance5.raw.color = new Color (0f, 255f, 0f);
	
		}else if(distance5.distance >distance5.range && mission5.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance5.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance6.distance<distance6.range && mission6.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (5,0,mission6.transform.position.x,mission6.transform.position.y,mission6.transform.position.z,mission6.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	

			distance6.raw.color = new Color (0f, 255f, 0f);

			
		}else if(distance6.distance >distance6.range && mission6.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance6.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance7.distance<distance7.range && mission7.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (6,0,mission7.transform.position.x,mission7.transform.position.y,mission7.transform.position.z,mission7.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	

			distance7.raw.color = new Color (0f, 255f, 0f);

				
		}else if(distance7.distance >distance7.range && mission7.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance7.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance8.distance<distance8.range && mission8.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (7,0,mission8.transform.position.x,mission8.transform.position.y,mission8.transform.position.z,mission8.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	

			distance8.raw.color = new Color (0f, 255f, 0f);


				
		}else if(distance8.distance >distance8.range && mission8.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance8.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance9.distance<distance9.range && mission9.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (8,0,mission9.transform.position.x,mission9.transform.position.y,mission9.transform.position.z,mission9.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	
			distance9.raw.color = new Color (0f, 255f, 0f);


			
		}else if(distance9.distance >distance9.range && mission9.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance9.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance10.distance<distance10.range && mission10.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (9,0,mission10.transform.position.x,mission10.transform.position.y,mission10.transform.position.z,mission10.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	
			distance10.raw.color = new Color (0f, 255f, 0f);


				
		}else if(distance10.distance >distance10.range && mission10.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance10.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance11.distance<distance11.range && mission11.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (10,0,mission11.transform.position.x,mission11.transform.position.y,mission11.transform.position.z,mission11.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	
			distance11.raw.color = new Color (0f, 255f, 0f);


				
		}else if(distance11.distance >distance11.range && mission11.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance11.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance12.distance<distance12.range && mission12.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (11,0,mission12.transform.position.x,mission12.transform.position.y,mission12.transform.position.z,mission12.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	
			distance12.raw.color = new Color (0f, 255f, 0f);

	
		}else if(distance12.distance >distance12.range && mission12.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance12.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance13.distance<distance13.range && mission13.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (12,0,mission13.transform.position.x,mission13.transform.position.y,mission13.transform.position.z,mission13.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	
			distance13.raw.color = new Color (0f, 255f, 0f);

	
		}else if(distance13.distance >distance13.range && mission13.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance13.raw.color = new Color (255f, 0f, 0f);
		
		}

		if(distance14.distance<distance14.range && mission14.activeInHierarchy == true){
			snapbut.enabled = true;
			snapimg.enabled = true;
			snaptxt.enabled = true;
			oscSender.setOSCData (13,0,mission14.transform.position.x,mission14.transform.position.y,mission14.transform.position.z,mission14.transform.rotation.eulerAngles.y);
			oscSender.MySendOSCMessageTriggerMethod();	
			distance14.raw.color = new Color (0f, 255f, 0f);


				
		}else if(distance14.distance >distance14.range && mission14.activeInHierarchy == true){
			snapbut.enabled = false;
			snapimg.enabled = false;
			snaptxt.enabled = false;
			distance14.raw.color = new Color (255f, 0f, 0f);
		
		}

	}
	public void Startmission(){

		switch (missionnum){

		case 0:
			//mission0Q
			blackview.SetActive (false);

			mission1.SetActive (true);
			god0box.enabled = true;
			god0line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 0;
			taskstatus = true;


			oscSender.setOSCData (0, 1, 0f, 0f, 0f, 0f);
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

			oscSender.setOSCData (1, 1, 0f, 0f, 0f, 0f);
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

			oscSender.setOSCData (2,1,0f,0f,0f,0f);
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

			oscSender.setOSCData (3,1,0f,0f,0f,0f);
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

			oscSender.setOSCData (4,1,0f,0f,0f,0f);
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

			oscSender.setOSCData (5,1,0f,0f,0f,0f);
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

			oscSender.setOSCData (6,1,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();

			break;
		
		case 7:


			blackview.SetActive(false);

			mission8.SetActive(true);
			blowing0box.enabled = true;
			blowing0line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 7;
			taskstatus = true;

			oscSender.setOSCData (7,1,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();

			break;

		case 8:

			blackview.SetActive(false);

			mission9.SetActive(true);
			blowing15box.enabled = true;
			blowing15line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 8;
			taskstatus = true;

			oscSender.setOSCData (8,1,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();

			break;

		case 9:

			blackview.SetActive(false);

			mission10.SetActive(true);
			bus30box.enabled = true;
			bus30line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 9;
			taskstatus = true;

			oscSender.setOSCData (9,1,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();

			break;

		case 10:

			blackview.SetActive(false);

			mission11.SetActive(true);
			bus45box.enabled = true;
			bus45line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 10;
			taskstatus = true;

			oscSender.setOSCData (10,1,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();

			break;

		case 11:

			blackview.SetActive(false);

			mission12.SetActive(true);
			boat60box.enabled = true;
			boat60line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 11;
			taskstatus = true;

			oscSender.setOSCData (11,1,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();

			break;

		case 12:

			blackview.SetActive(false);

			mission13.SetActive(true);
			boat75box.enabled = true;
			boat75line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 12;
			taskstatus = true;

			oscSender.setOSCData (12,1,0f,0f,0f,0f);
			oscSender.MySendOSCMessageTriggerMethod();

			break;

		case 13:

			blackview.SetActive(false);

			mission14.SetActive(true);
			bus90box.enabled = true;
			bus90line.enabled = true;

			startbut.enabled = false;
			startimg.enabled = false;
			txt.enabled = false;

			missionnum = 13;
			taskstatus = true;

			oscSender.setOSCData (13,1,0f,0f,0f,0f);
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
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission1.SetActive (false);
				god0box.enabled = false;
				god0line.enabled = false;

				time.status = false;


//				oscSender.setOSCData (0, 0, mission1.transform.position.x, mission1.transform.position.y, mission1.transform.position.z, mission1.transform.rotation.eulerAngles.y, cam1.transform.rotation.eulerAngles.x);
//
//
//				oscSender.MySendOSCMessageTriggerMethod ();	

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
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission2.SetActive(false);
				god15box.enabled = false;
				god15line.enabled = false;

				missionnum = 2;

				time.status = false;

//				oscSender.setOSCData (1,0,mission2.transform.position.x,mission2.transform.position.y,mission2.transform.position.z,mission2.transform.rotation.eulerAngles.y,cam2.transform.rotation.eulerAngles.x);
//				oscSender.MySendOSCMessageTriggerMethod();	

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
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission3.SetActive(false);
				ship30box.enabled = false;
				ship30line.enabled = false;

				missionnum = 3;
				time.status = false;


//				oscSender.setOSCData (2,0,mission3.transform.position.x,mission3.transform.position.y,mission3.transform.position.z,mission3.transform.rotation.eulerAngles.y,cam3.transform.rotation.eulerAngles.x);
//				oscSender.MySendOSCMessageTriggerMethod();	
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
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission4.SetActive(false);
				ship45box.enabled = false;
				ship45line.enabled = false;

				missionnum = 4;

				time.status = false;

//				oscSender.setOSCData (3,0,mission4.transform.position.x,mission4.transform.position.y,mission4.transform.position.z,mission4.transform.rotation.eulerAngles.y,cam4.transform.rotation.eulerAngles.x);
//				oscSender.MySendOSCMessageTriggerMethod();	
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
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission5.SetActive(false);
				car60box.enabled = false;
				car60line.enabled = false;

				missionnum = 5;

				time.status = false;

//				oscSender.setOSCData (4,0,mission5.transform.position.x,mission5.transform.position.y,mission5.transform.position.z,mission5.transform.rotation.eulerAngles.y,cam5.transform.rotation.eulerAngles.x);
//				oscSender.MySendOSCMessageTriggerMethod();	

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
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission6.SetActive(false);
				car75box.enabled = false;
				car75line.enabled = false;

				missionnum = 6;

				time.status = false;

//				oscSender.setOSCData (5,0,mission6.transform.position.x,mission6.transform.position.y,mission6.transform.position.z,mission6.transform.rotation.eulerAngles.y,cam6.transform.rotation.eulerAngles.x);
//				oscSender.MySendOSCMessageTriggerMethod();	
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
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission7.SetActive(false);
				ship90box.enabled = false;
				ship90line.enabled = false;

				missionnum = 7;

				time.status = false;

//				oscSender.setOSCData (6,0,mission7.transform.position.x,mission7.transform.position.y,mission7.transform.position.z,mission7.transform.rotation.eulerAngles.y,cam7.transform.rotation.eulerAngles.x);
//				oscSender.MySendOSCMessageTriggerMethod();	

				taskstatus = false;
			}

			break;


		case 7:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission8.SetActive(false);
				blowing0box.enabled = false;
				blowing0line.enabled = false;

				missionnum = 8;

				time.status = false;
				taskstatus = false;
			}

			break;

		case 8:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission9.SetActive(false);
				blowing15box.enabled = false;
				blowing15line.enabled = false;

				missionnum = 9;

				time.status = false;
				taskstatus = false;
			}

			break;

		case 9:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission10.SetActive(false);
				bus30box.enabled = false;
				bus30line.enabled = false;

				missionnum = 10;

				time.status = false;
				taskstatus = false;
			}

			break;

		case 10:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission11.SetActive(false);
				bus45box.enabled = false;
				bus45line.enabled = false;

				missionnum = 11;

				time.status = false;
				taskstatus = false;
			}

			break;

		case 11:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission12.SetActive(false);
				boat60box.enabled = false;
				boat60line.enabled = false;

				missionnum = 12;

				time.status = false;
				taskstatus = false;
			}

			break;


		case 12:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission13.SetActive(false);
				boat75box.enabled = false;
				boat75line.enabled = false;

				missionnum = 13;

				time.status = false;
				taskstatus = false;
			}

			break;

		case 13:

			if (taskstatus == true) {

				blackview.SetActive(true);

				startbut.enabled = true;
				startimg.enabled = true;
				txt.enabled = true;
				snapbut.enabled = false;
				snapimg.enabled = false;
				snaptxt.enabled = false;
				mission14.SetActive(false);
				bus90box.enabled = false;
				bus90line.enabled = false;

				missionnum = 14;

				time.status = false;
				taskstatus = false;
			}

			break;
		}





	
	}

}
