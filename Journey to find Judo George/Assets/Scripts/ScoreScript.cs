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
				//float newScale = Mathf.Lerp (1, 3, timer);
				Scale = SammyHappy.transform.localScale + new Vector3(0,1f,0);
				SammyHappy.transform.localScale = new Vector3(1, newScale, 1);
				SammyHappy.transform.position = SammyHappy.transform.position + new Vector3(0,1,0);

				go = false;
			
		}
	}
	
	void OnMouseDown()
	{
		if((gameObject.tag == "choice1"))
		{
			go = true;
			
		}
		
		
	}
}
