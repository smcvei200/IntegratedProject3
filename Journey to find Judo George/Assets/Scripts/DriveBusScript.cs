using UnityEngine;
using System.Collections;

public class DriveBusScript: MonoBehaviour {
	
	public int speed = 5;
	public Transform Bus;
	// Use this for initialization
	public void Update(){	
		
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(Vector3.up* speed * Time.deltaTime);
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				transform.Rotate(0,0, speed* Time.deltaTime*30);
			}
			
			if(Input.GetKey(KeyCode.RightArrow))
			{
				transform.Rotate (0,0,-speed* Time.deltaTime*30);
			}
		}
		
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(Vector3.down*speed * Time.deltaTime);
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				transform.Rotate(0,0, -speed* Time.deltaTime*30);
			}
			
			if(Input.GetKey(KeyCode.RightArrow))
			{
				transform.Rotate (0,0,speed* Time.deltaTime*30);
			}
		}
		

	}
}