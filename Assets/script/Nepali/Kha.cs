﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kha : MonoBehaviour
{
	public bool firstorder = true;
	public bool secondorder = false;
	public bool thirdorder=false;
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
		if (Physics.Raycast (ray, out hitpoint)) 
		{

			if (hitpoint.collider.name != "wallpaper")
			{

				if (hitpoint.transform.gameObject.tag == "Top" && firstorder) {

					hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.red;
				}
				if (hitpoint.transform.gameObject.tag == "khaside" && secondorder) {

					hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.red;
				}

				if (hitpoint.transform.gameObject.tag == "verticle" && thirdorder) {

					hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.red;

				}
			}

		}




	}
}