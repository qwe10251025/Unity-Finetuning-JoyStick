/*/
* Script by Devin Curry
* http://Devination.com
* https://youtube.com/user/curryboy001
* Please like and subscribe if you found my tutorials helpful :D
* Twitter: https://twitter.com/Devination3D
/*/
using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class FloatingPlayer2DController : MonoBehaviour
{
	public float moveForce = 5, boostMultiplier = 2;
	Rigidbody2D myBody;

	float Lh,Lv ,Rh,Rv;


	void Start ()
	{
		myBody = this.GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate ()
	{
//		Vector3 moveVec = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"),
//			CrossPlatformInputManager.GetAxis("Vertical"))
//			* moveForce;
//		Vector3 lookVec = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal_2"),
//			CrossPlatformInputManager.GetAxis("Vertical_2"), 4096);

//		if (moveVec.y != 0) {
//			if( moveVec.y > 1 ){
//				transform.Translate (0f,1,0f);
//			}
//		}
//		if (lookVec.x != 0 && lookVec.y != 0)
//			transform.rotation = Quaternion.LookRotation(lookVec, Vector3.back);
//		
//		bool isBoosting = CrossPlatformInputManager.GetButton("Boost");
//		myBody.AddForce(moveVec * (isBoosting ? boostMultiplier : 1));

		Lh = CrossPlatformInputManager.GetAxis ("Horizontal");
		Lv = CrossPlatformInputManager.GetAxis ("Vertical");
		Rh = CrossPlatformInputManager.GetAxis ("Horizontal_2");
		Rv = CrossPlatformInputManager.GetAxis ("Vertical_2");


		if (Rv > 0 && Rh < 0.2  && Rh > -0.2) {
			transform.Translate (0,0,  1f*Time.deltaTime);

		} else if (Rv < 0 && Rh < 0.2 && Rh > -0.2) {
		
			transform.Translate (0, 0, -1f*Time.deltaTime);

		}

		if (Rh > 0 && Rv < 0.2  && Rv > -0.2) {
		
			transform.Translate (1f*Time.deltaTime, 0, 0);

		} else if (Rh < 0 && Rv < 0.2  && Rv > -0.2) {

			transform.Translate (-1f*Time.deltaTime, 0, 0);

		}

		if (Lv > 0 && Lh < 0.5  && Lh > -0.5) {
			transform.Translate (0, 1f*Time.deltaTime, 0);

		} else if (Lv < 0 && Lh < 0.5  && Lh > -0.5) {
		
			transform.Translate (0, -1f*Time.deltaTime, 0);

		}

//		if (Lh > 0 && Lv < 0.2  && Lv > -0.2) {
//			transform.Rotate (0,0.5f,0);
//		}else if (Lh < 0 && Lv < 0.2  && Lv > -0.2) {
//			transform.Rotate (0,-0.5f,0);
//		}
	}
}