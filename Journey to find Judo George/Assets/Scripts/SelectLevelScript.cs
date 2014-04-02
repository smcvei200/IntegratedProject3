using UnityEngine;
using System.Collections;

public class SelectLevelScript : MonoBehaviour {
<<<<<<< HEAD

	
	public Transform level1;
	public Transform level2;
=======
	
	public Transform level1;
	public Transform level2;
	
	bool isTriggered = false;
	string levelSelect;
	
	Color badColor = new Color(150,0,0,0.4f);
>>>>>>> 239ed0338051d40fbfdab3bf8aafd96bf36ed6af
	// Use this for initialization
	void Start () {
	
		level1.renderer.enabled = false;
		level2.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {		
	
	}
	
	void OnMouseDown()
	{
<<<<<<< HEAD
=======
		isTriggered = true;
		other.renderer.material.color = Color.red;
		levelSelect = other.gameObject.tag.ToString();
	}

	void OnTriggerExit(Collider other)
	{
		other.renderer.material.color = badColor;
	}
	
	void OnMouseDown()
	{
>>>>>>> 239ed0338051d40fbfdab3bf8aafd96bf36ed6af
		if(gameObject.tag == "level1")
		{
			Application.LoadLevel("TheClassroom");
		}
<<<<<<< HEAD
		else if(gameObject.tag == "level2")
		{
			Application.LoadLevel ("TheBus");
		}
=======
		
		else if(gameObject.tag == "level2")
		{
			Application.LoadLevel("TheClassroom");
		}
		
	}
	
	void OnMouseEnter()
	{
		
		if(gameObject.tag == "level1")
		{
			level1.renderer.enabled = true;
		renderer.material.color = badColor;
		}
		else if(gameObject.tag == "level2")
		{
			level2.renderer.enabled = true;
		renderer.material.color = badColor;
		}
	}
	void OnMouseExit()
	{
		level1.renderer.enabled = false;
		level2.renderer.enabled = false;
>>>>>>> 239ed0338051d40fbfdab3bf8aafd96bf36ed6af
	}
}