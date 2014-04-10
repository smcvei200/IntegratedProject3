using UnityEngine;
using System.Collections;

public class QuitScript : MonoBehaviour {
	
	public Transform Quit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown()
	{
		if(gameObject.tag == "Quit")
		{
			Application.Quit();
		}
		if(gameObject.tag == "Back")
		{
			Application.LoadLevel("LevelSelect");
		}
	}
	
	void OnMouseOver()
	{
		Quit.renderer.material.color = Color.red;
	}
	void OnMouseExit()
	{
		Quit.renderer.material.color = Color.blue;
	}
}
