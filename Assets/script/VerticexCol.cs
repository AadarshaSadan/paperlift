using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticexCol : MonoBehaviour {

	private Mesh fmesh;

	void Start()
	{
		fmesh = GetComponent<MeshFilter>().mesh;
		Color[] fcolors = fmesh.colors;

		Debug.Log(fcolors.Length);

	}
}
