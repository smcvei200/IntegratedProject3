using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour {
	
	public Transform Elephant;
	public Transform StartPos;
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Elephant.transform.Translate(-speed*Time.deltaTime,0,0);
		
	}
	
	void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.name == "Elephant")
		{
			Elephant.transform.position = StartPos.position;
		}
	}
}
