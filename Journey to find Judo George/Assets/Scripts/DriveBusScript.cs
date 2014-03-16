using UnityEngine;
using System.Collections;

public class DriveBus : MonoBehaviour {
	
	public int speed = 20;
	public Transform Bus;
	// Use this for initialization
	public void Update(){	
		
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.up* speed * Time.deltaTime);
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				transform.Rotate(0,0, speed* Time.deltaTime);
			}
			
			if(Input.GetKey(KeyCode.RightArrow))
			{
				transform.Rotate (0,0,-speed* Time.deltaTime);
			}
		}
		
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.down*speed * Time.deltaTime);
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				transform.Rotate(0,0, -speed* Time.deltaTime);
			}
			
			if(Input.GetKey(KeyCode.RightArrow))
			{
				transform.Rotate (0,0,speed* Time.deltaTime);
			}
		}
		

	}
}