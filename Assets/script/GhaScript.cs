using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhaScript : MonoBehaviour
{
	public Camera mainCamera;
	public GameObject checkpoint1;
	public GameObject checkpoint2;
	public GameObject checkpoint3;

	public bool firstpoint;
	public bool secondpoint;
	public bool thirdpoint;

	public int count = 1;

	// Use this for initialization
	void Start ()
	{
		firstpoint = true;
		secondpoint = false;
		thirdpoint = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray ray = mainCamera.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitpoint;
		if (Physics.Raycast (ray, out hitpoint)) {
			Debug.Log (hitpoint.transform.parent);


			if (hitpoint.collider.name != "wallpaper" && hitpoint.collider.name != "firstline" && firstpoint) {
				hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.red;
			} 

			if (hitpoint.collider.name != "wallpaper" && hitpoint.transform.parent.name == "Topline" && secondpoint) {
				firstpoint = false;
				hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.red;

			}
			if (hitpoint.collider.name != "wallpaper" && hitpoint.transform.parent.name == "downline" && thirdpoint) {
				firstpoint = false;
				hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.red;
			} else {
				firstpoint = true;
			}


		}

	}
}
