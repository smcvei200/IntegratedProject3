using UnityEngine;
using System.Collections;

public class SelectLevelScript : MonoBehaviour {

	bool isTriggered = false;
	string levelSelect;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isTriggered == true) 
		{			
			if (Input.GetKey (KeyCode.Return)) 
			{				
				
				switch(levelSelect)
				{
				case "Level1":
					Application.LoadLevel("OpeningScene");
					break;
				case "Level2":
					Application.LoadLevel ("Level2");
					break;
				case "Level3":
					Application.LoadLevel("Level3");
					break;
				case "Level4":
					Application.LoadLevel ("Level4");
					break;
				case "Level5":
					Application.LoadLevel("Level5");
					break;				
					
				}
			}
		}
		
	
	}
	
	void OnTriggerEnter(Collider other)
	{
		isTriggered = true;
		other.renderer.material.color = Color.red;
		levelSelect = other.gameObject.tag.ToString();
	}

	void OnTriggerExit(Collider other)
	{
		other.renderer.material.color = Color.white;
	}
}