using UnityEngine;
using System.Collections;

public class DriveBusScript: MonoBehaviour {
	
	public int speed = 5;
	public Transform Bus;
	
	private bool LookUp = true;
	private bool LookDown = false;
	private bool LookLeft = false;
	private bool LookRight = false;
	
	// Use this for initialization
	public void Update(){	
		
		
		
		if(Input.GetKey(KeyCode.UpArrow))
		{
			if(LookRight == true)
			{
				transform.Rotate(0,0,90);
			}
			else if(LookRight == true)
			{
				transform.Rotate (0,0,-90);
			}
			else if(LookDown == true)
			{
				transform.Rotate(0,0,180);
			}
			transform.Translate(Vector3.down* speed * Time.deltaTime);
			LookUp = true;
			LookDown = false;
			LookRight = false;
			LookLeft = false;
		}
		
		if(Input.GetKey(KeyCode.DownArrow))
		{
			if(LookRight == true)
			{
				transform.Rotate (0,0,-90);
			}
			else if (LookLeft == true)
			{
				transform.Rotate (0,0,90);
			}
			else if ( LookUp == true)
			{
				transform.Rotate (0,0,180);
			}
			
			transform.Translate(Vector3.down*speed * Time.deltaTime);
			LookDown = true;
			LookLeft = false;
			LookRight = false;
			LookUp = false;
		}
		
		
			if(Input.GetKey(KeyCode.LeftArrow))
			{
				if(LookUp == true)
				{
					transform.Rotate (0,0,90);
				}
				else if ( LookDown == true)
				{
					transform.Rotate (0,0,-90);
				}
				else if ( LookRight == true)
				{
					transform.Rotate (0,0,180);
				}
				transform.Translate (Vector3.down*speed*Time.deltaTime);
				LookLeft = true;
				LookRight = false;
				LookUp = false;
				LookDown = false;
			}
		
			
		if(Input.GetKey(KeyCode.RightArrow))
		{
			if(LookUp == true)
			{
				transform.Rotate (0,0,-90);
			}
			else if ( LookDown == true)
			{
				transform.Rotate (0,0,90);
			}
			else if ( LookLeft == true)
			{
				transform.Rotate (0,0,180);
			}
			transform.Translate (Vector3.down*speed*Time.deltaTime);
			LookLeft = false;
			LookRight = true;
			LookUp = false;
			LookDown = false;
			
		}
		
		

	}
	

}