using UnityEngine;
using System.Collections;

public class FollowMouseScript : MonoBehaviour {

	public Transform Player;
	public Transform mainCamera;
	public int speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (Input.GetAxis ("Mouse X"));
		//transform.Rotate (Vector3.right * Time.deltaTime);
		//Player.transform.Rotate(Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speed);
		if(Input.GetAxis("Mouse X") < 0) 
		{
			Player.transform.Rotate(0, -speed * Time.deltaTime,0);
		}
		if(Input.GetAxis("Mouse X") > 0) 
		{
			Player.transform.Rotate(0,speed * Time.deltaTime, 0 );
		}

		if ((Input.mousePosition.x > Screen.width) && (mainCamera.position.x < 10))
		{
			mainCamera.transform.Translate(speed*Time.deltaTime,0,0);
		}
		if ((Input.mousePosition.x == 0) && (mainCamera.position.x >-40))
		{
			mainCamera.transform.Translate(-speed*Time.deltaTime,0,0);
		}

	}
}
