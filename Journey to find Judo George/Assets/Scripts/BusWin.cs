using UnityEngine;
using System.Collections;

public class BusWin : MonoBehaviour {
	
	public Transform Bus;
	public TextMesh Done;
	private float runtime = 0f;
	private bool go = false;
	public TextMesh info;
	private bool start = true;
	private float infoTime = 0f;
	public Transform arrow;
	// Use this for initialization
	void Start () {
		
		Done.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(start == true)
		{
			infoTime += Time.deltaTime;
			if(infoTime>5.0f)
			{
				info.renderer.enabled = false;
				arrow.renderer.enabled = false;
			}
		}
		if(go==true)
		{
			runtime += Time.deltaTime;
			if(runtime > 5.0f)
			{
				Application.LoadLevel("LevelSelect");
			}
		}
	}
	
	void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.name == "Bus")
		{
			Done.renderer.enabled = true;
			go= true;
		}
	}
}
