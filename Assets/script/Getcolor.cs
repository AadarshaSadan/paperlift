using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getcolor : MonoBehaviour
{
	private Renderer rend;
	public GameObject sphcol;
	public GameObject defaultobj;
	int childnumber;
	public int previousn;
	public int count;
  


	// Use this for initialization
	void Start ()
	{
		//Renderer rend = GetComponent<Renderer> ();
		childnumber = this.transform.childCount;
		Debug.Log (childnumber);



	}
	
	// Update is called once per frame
	void Update ()
	{
		//findHowmanywhite ();
	}

	public void findHowmanywhite()
	{
		count = 0;
		for(int i=0;i<childnumber;i++)
		{
			previousn = count - previousn;
			if (this.transform.GetChild (i).GetComponent<Renderer> ().material.GetColor ("_Color") == defaultobj.GetComponent<Renderer> ().material.GetColor ("_Color")) {
				
				count++;


			} 
		}
		Debug.Log (count);
	}
}

