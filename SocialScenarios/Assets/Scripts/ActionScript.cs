using UnityEngine;
using System.Collections;

public class ActionScript : MonoBehaviour {

	public Transform Action;
	public Transform Answers;
	// Use this for initialization
	void Start () {
		Answers.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Answers.renderer.enabled = true;
		Answers.renderer.material.color = Color.red;
	}

}
