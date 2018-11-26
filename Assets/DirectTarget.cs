using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectTarget : MonoBehaviour
{

	public GameObject Target;
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Renderer>().material.SetVector("_TargetPosition",Target.transform.position);
	}
}
