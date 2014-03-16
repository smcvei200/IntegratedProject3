using UnityEngine;
using System.Collections;

public class FollowMouseScript : MonoBehaviour {

	public Transform Player;
	public int speed = 10;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		
		if((Input.GetAxis("Mouse X") < 0)&&(Input.mousePosition.x > 0))
		{
			
			Player.transform.Rotate(0, -speed * Time.deltaTime,0);
		}
		if((Input.GetAxis("Mouse X") > 0)&&(Input.mousePosition.x < Screen.width)) 
		{
			
			Player.transform.Rotate(0,speed * Time.deltaTime, 0 );
		}

	}
}