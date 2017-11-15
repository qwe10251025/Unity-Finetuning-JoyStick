using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control : MonoBehaviour {



	private Vector3 moveDirection = Vector3.zero;
	public Image img;

	float num;
	public Camera cam;
	float imgy;
	float imgV;
	//public float n =  -90;

	public GameObject A;
	public GameObject Q;
	public RawImage raw;

	Vector3 posA ;
	Vector3 posQ ;


	public float distance ;
	// Update is called once per frame
    void Update () {




		movePlayer();

		num = cam.transform.rotation.eulerAngles.x ; 
		imgy = cam.transform.rotation.eulerAngles.x ;

		if(imgy<45){}
		imgV = (imgy - 0) / (90) * (155 - 155 * -1) - 155;
		//Debug.Log ("num"+num);
		//imgy = imgy+155;

		img.transform.localPosition = new Vector3(434,-1*imgV,0);
		//Debug.Log ("imgy"+imgy);

		posA = A.transform.position;
		posQ = Q.transform.position;
	

		distance = (posA - posQ).magnitude;

		if (distance < 0.4) {

			raw.color = new Color (0f, 255f, 0f);
			Debug.Log ("Get");
		} else {
			raw.color = new Color (255f, 0f, 0f);

		
		}
	}

	void movePlayer()

	{

		CharacterController controller = GetComponent<CharacterController>();

//		if (controller.isGrounded)
//		{
//			moveDirection = new Vector3(0, 0,Touch.playerTurnAxisTouch);
//			moveDirection = transform.TransformDirection(moveDirection);
//		
//
//		}
//		controller.Move(moveDirection * Time.deltaTime);
//
		//Rotate Player
		//transform.Rotate(0, Touch.playerTurnAxisTouch, 0);




		if (num > 0) {


			if (num > 89 && num < 90) {




				if (Touch.x > 0) {

					cam.transform.Rotate (0, 0, 0);
					//img.transform.Translate (0,0,0);



				} else if (Touch.x < 0) {
						
					num = num + Touch.x ;
					num = (float)System.Math.Round (num,1);
					cam.transform.localEulerAngles = new Vector3(num,0,0) ;


				}

			
			} 
				else if (num > 359) {

				if (Touch.x < 0) {
					cam.transform.Rotate (0, 0, 0);
					//img.transform.Translate (0,0,0);


				} else if (Touch.x > 0) {


					num = num + Touch.x ;
					num = (float)System.Math.Round (num,1);

					cam.transform.localEulerAngles = new Vector3(num,0,0) ;

					//img.transform.Translate (Touch.x*-1.72f,0,0);

				}

			} 
				else {
			
				//cam.transform.Rotate (Touch.x, 0, 0);

				num = num + Touch.x ;

//				cam.transform.eulerAngles = new Vector3(num,0,0) ;
				num = (float)System.Math.Round (num,1);

				cam.transform.localEulerAngles = new Vector3(num,0,0) ;
				//img.transform.Translate (Touch.x*-1.72f,0,0);

			
			}
		}

		

		if (num == 0) {

			if (Touch.x < 0) {
				cam.transform.Rotate (0, 0, 0);
				//img.transform.Translate (0,0,0);


			} else if(Touch.x >0){

				num = num + Touch.x ;
				num = (float)System.Math.Round (num,1);

				cam.transform.localEulerAngles = new Vector3(num,0,0) ;				
				//cam.transform.Rotate(Touch.x,0,0);

				//img.transform.Translate (Touch.x*-1.72f,0,0);

			}
		
		}

	
	
	}

}
