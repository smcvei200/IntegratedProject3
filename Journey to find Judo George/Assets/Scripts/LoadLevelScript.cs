using UnityEngine;
using System.Collections;

public class LoadLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void OnMouseEnter(){
		
		renderer.material.color = Color.red;
	}
	
	public void OnMouseExit(){
	
		renderer.material.color = Color.green;
	}
	
	public void OnMouseDown(){
	
		Application.LoadLevel(1);
	}
}