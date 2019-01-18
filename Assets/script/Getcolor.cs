using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Getcolor : MonoBehaviour
{
	private Renderer rend;
	public GameObject sphcol;
	public GameObject defaultobj;
	int childnumber;
	public int count;
	//public int lastcount=0;
	string thisScene;
	public GameObject completed;
	AudioSource audior;

	[SerializeField]
	private bool isplay;
	// Use this for initialization
	void Start ()
	{
		//Renderer rend = GetComponent<Renderer> ();
		childnumber = this.transform.childCount;
		Debug.Log (childnumber);
		thisScene = SceneManager.GetActiveScene ().name;
		Debug.Log (thisScene);
		audior = GetComponent<AudioSource> ();



	}
	
	// Update is called once per frame
	void Update ()
	{
		if (thisScene == "Gha" && findHowmanywhite () == 0) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}
		if (thisScene == "GA" && findHowmanywhite () == 0) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}
		if (thisScene == "KHA" && findHowmanywhite () == 0) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}

		if (thisScene == "Naag" && findHowmanywhite () == 0) {
			//if (!audior.isPlaying)
				//audior.Play ();
			StartCoroutine (waitanysecond (1));
		}
		if (thisScene == "KA" && findHowmanywhite () == 1) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}


	}

	int findHowmanywhite ()
	{
		count = 0;
		for (int i = 0; i < childnumber; i++) {
			if (this.transform.GetChild (i).GetComponent<Renderer> ().material.GetColor ("_Color") == defaultobj.GetComponent<Renderer> ().material.GetColor ("_Color")) {
				count++;
			} 
		}
		//Debug.Log (count);
		return count;
	}

	IEnumerator waitanysecond (int sec)
	{
		completed.SetActive (true);
		yield return new WaitForSeconds (sec);
		if (thisScene == "Gha")
			SceneManager.LoadScene ("Naag");
		if (thisScene == "GA")
			SceneManager.LoadScene ("Gha");
		if (thisScene == "KHA")
			SceneManager.LoadScene ("GA");
		if (thisScene == "KA")
			SceneManager.LoadScene ("KHA");
	}

}

