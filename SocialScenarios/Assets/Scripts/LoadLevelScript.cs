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
	
		renderer.material.color = Color.white;
	}
	
	public void OnMouseDown(){
	
		Application.LoadLevel(1);
	}
}
