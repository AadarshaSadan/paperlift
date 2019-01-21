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

	public int counttag;
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

		if (thisScene == "A" && findHowmanywhite () == 1) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}
		if (thisScene == "B" && findHowmanywhite () == 1) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}

		if (thisScene == "C" && findHowmanywhite () == 1) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}
		if (thisScene == "D" && findHowmanywhite () == 1) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}
		if (thisScene == "E" && findHowmanywhite () == 1) {
			if (!audior.isPlaying)
				audior.Play ();
			StartCoroutine (waitanysecond (1));
		}

		Debug.Log (findhowmanywithTag ("khaside"));
		Debug.Log (findhowmanywithTag ("Top"));
		Debug.Log(findhowmanywithTag("verticle"));
		Debug.Log (findhowmanywithTag("okha"));
			



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


	int findhowmanywithTag(string Tagname)
	{
		counttag = 0;
		for (int i = 0; i < childnumber; i++) {
			if (this.transform.GetChild (i).GetComponent<Renderer> ().material.GetColor ("_Color") == defaultobj.GetComponent<Renderer> ().material.GetColor ("_Color")
				&& this.transform.GetChild(i).tag==Tagname) {
				counttag++;
			}


		}
		return counttag;

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
		if (thisScene == "A")
			SceneManager.LoadScene ("B");
		if (thisScene == "B")
			SceneManager.LoadScene ("C");
		if (thisScene == "C")
			SceneManager.LoadScene ("D");
		if (thisScene == "D")
			SceneManager.LoadScene ("E");
	}
	



	




}

