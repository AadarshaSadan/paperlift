using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KhaScript : MonoBehaviour
{
	public GameObject checkpoint1;
	public GameObject checkpoint2;
	public GameObject checkpoint3;

	public bool check1;

	public Camera mainCamera;

	[SerializeField]
	private bool topline;
	[SerializeField]
	private bool secondlinedraw;
	[SerializeField]
	private bool firstdraw;
	// Use this for initialization
	public bool isonsecond;
	void Start ()
	{
		topline = false;
		secondlinedraw = true;
		firstdraw = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray ray = mainCamera.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitpoint;
		if (Physics.Raycast (ray, out hitpoint)) {
			//try {

			Debug.Log(hitpoint.transform.parent);
				/*if (hitpoint.collider.name != "wallpaper" && hitpoint.transform.parent.name == "firstdraw" && firstdraw) {
 
					hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.blue;	
					secondlinedraw = true;
				}*/
			/*if(hitpoint.transform.parent.name)
				{
					Debug.Log("getthispoint");
				}
			*/
				if (hitpoint.collider.name != "wallpaper"  ) {
					hitpoint.collider.GetComponent<MeshRenderer> ().material.color = Color.blue;
					Debug.Log (hitpoint.transform.parent);
					firstdraw = false;
				}
				 

		//	} catch (Exception e) {
		//		Debug.LogException (e, this);
		//		Debug.Log ("something Error in code");
			//}

		}

	}

}

