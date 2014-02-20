using UnityEngine;
using System.Collections;

public class MovePlayerScript : MonoBehaviour {
	
	public int speed = 10;
	public Transform Player;
	// Use this for initialization
	public void Update(){
		
		
	
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(0,speed*Time.deltaTime,0);
		}
		
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(0,-speed*Time.deltaTime,0);
		}
		
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(-speed*Time.deltaTime,0,0);
		}
		
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(speed*Time.deltaTime,0,0);
		}
	}
}
