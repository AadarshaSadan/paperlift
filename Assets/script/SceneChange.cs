﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


	public void mainplay()
	{
		SceneManager.LoadScene ("Menu");
	}



	public void TOkA ()
	{
		SceneManager.LoadScene ("KA");
	}

	public void ToKHA ()
	{
		SceneManager.LoadScene ("KHA");
	}

	public void ToGA ()
	{
		SceneManager.LoadScene ("GA");
	}

	public void ToGha ()
	{
		SceneManager.LoadScene ("Gha");
	}

	public void ToNag ()
	{
		SceneManager.LoadScene ("Naag");
	}

    
}
