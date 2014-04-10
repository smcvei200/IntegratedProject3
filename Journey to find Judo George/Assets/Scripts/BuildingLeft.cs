using UnityEngine;
using System.Collections;

public class BuildingLeft : MonoBehaviour {
	
	public Transform Bus;
	private float busX;
	private float busY;
	private float busZ;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		busX = Bus.transform.position.x;
		busY = Bus.transform.position.y;
		busZ = Bus.transform.position.z;
		
	}
		void OnTriggerEnter(Collider c)
	{
		if(c.gameObject.name == "Bus")
		{
	
				Bus.transform.position = new Vector3(busX - 0.5f, busY, busZ);
			
		}
	}
}
