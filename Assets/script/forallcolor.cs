using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forallcolor : MonoBehaviour
{
	
	public Camera mainCamera;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray ray = mainCamera.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitpoint;
		if (Physics.Raycast (ray, out hitpoint)) {

			if (hitpoint.collider.name != "wallpaper") {
				hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.red;
				Debug.Log (hitpoint.transform.parent);

			}
		}
	}
}
