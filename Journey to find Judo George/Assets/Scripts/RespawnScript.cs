using UnityEngine;
using System.Collections;

public class RespawnScript : MonoBehaviour {
	
	public Transform Bus;
	public Transform StartPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.name == "Bus")
		{
			Bus.transform.position = StartPos.position;
		}
	}
}
