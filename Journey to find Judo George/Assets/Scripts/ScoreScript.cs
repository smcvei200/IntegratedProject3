using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	
	public Transform choice1;
	public Transform choice2;
	public Transform SammyHappy;
	public int happy = 5;
	public int medium = 5;
	private bool go = false;
	private Vector3 Scale;
	
	 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(go == true)
		{				
				
				SammyHappy.transform.localScale += new Vector3(0,1f,0);
			
				SammyHappy.transform.position = SammyHappy.transform.position + new Vector3(0,1,0);

				go = false;
			
		}
	}
	
	void OnMouseDown()
	{
		if((gameObject.tag == "choice1"))
		{
			if(choice1.renderer.enabled == true)
			{
				go = true;
			}
		}
		
		
	}
}
