using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float h=0, v=0;
	// Update is called once per frame
	void Update ()
	{	
		h -= Input.GetAxis("Mouse X");
		v += Input.GetAxis("Mouse Y");
		Camera.main.transform.eulerAngles=new Vector3(-v,-h,0);

		
		
		transform.GetComponent<Rigidbody>().AddForce(Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0)*new Vector3(Input.GetAxis("Horizontal") * 20, 0, Input.GetAxis("Vertical") * 20));	
	}
}
