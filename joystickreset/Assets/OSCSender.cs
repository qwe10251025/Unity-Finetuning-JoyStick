using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniOSC;
using OSCsharp.Data;

public class OSCSender : UniOSCEventDispatcher {

	private	int Command;
	private int Status;
	private	float X;
	private	float Y;
	private	float Z;
	private	float Rotate;
	private	float Gimble;


		public override void Awake(){
		base.Awake ();
		}
	
		public override void OnEnable(){
			base.OnEnable ();
			ClearData ();
			AppendData (123);
			AppendData (123);
			AppendData (123.0f);
			AppendData (123.0f);
			AppendData (123.0f);
			AppendData (123.0f);
			AppendData (123.0f);
			//AppendData ("MyString");
		}
		public override void OnDisable(){
			base.OnDisable ();
		}

		public void MySendOSCMessageTriggerMethod(){
			if (_OSCeArg.Packet is OscMessage) {
				OscMessage msg = ((OscMessage)_OSCeArg.Packet);
				_updateOscMessageData (msg);
			} else if (_OSCeArg.Packet is OscBundle) {
				foreach (OscMessage msg2 in ((OscBundle)_OSCeArg.Packet).Messages) {
					_updateOscMessageData (msg2);
				}

			}
			//Here iwe trigger the sending
			_SendOSCMessage(_OSCeArg);

		}

		private void _updateOscMessageData(OscMessage msg){
			
			msg.UpdateDataAt (0, Command);
			msg.UpdateDataAt (1, Status);
			msg.UpdateDataAt (2, X);
			msg.UpdateDataAt (3, Y); 
			msg.UpdateDataAt (4, Z); 
			msg.UpdateDataAt (5, Rotate); 
			msg.UpdateDataAt (6, Gimble); 

		}

	public void setOSCData(int Command, int Status,float X,float Y,float Z,float Rotate,float Gimble){
			this.Command = Command;
			this.Status = Status;
			this.X = X;
			this.Y = Y;

			this.Z = Z;

			this.Rotate = Rotate;
			this.Gimble = Gimble;


		}





}
