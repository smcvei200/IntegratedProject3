using UnityEngine;
using System.Collections;

public class SelectLevelScript : MonoBehaviour {

	
	public Transform level1;
	public Transform level2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {		
	
	}
	
	void OnMouseDown()
	{
		if(gameObject.tag == "level1")
		{
			Application.LoadLevel("TheClassroom");
		}
		else if(gameObject.tag == "level2")
		{
			Application.LoadLevel ("TheBus");
		}
	}
}