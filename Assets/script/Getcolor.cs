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
    public GameObject CusorSprite;
    public int counttag;
    string thisScene;
    public GameObject completed;
    AudioSource audior;

    [SerializeField]
    private bool isplay;
    // Use this for initialization
    void Start()
    {
        //Renderer rend = GetComponent<Renderer> ();
        childnumber = this.transform.childCount;
        Debug.Log(childnumber);
        thisScene = SceneManager.GetActiveScene().name;
        Debug.Log(thisScene);
        audior = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {


        if (thisScene == "Kha")
            forkha();

        if (thisScene == "GA")
            forga();

        if (thisScene == "Gha")
            forgha();
        if (thisScene == "Naag")
            fornaa();

        if (thisScene == "A")
            forA();
        if (thisScene == "B")
            forB();
        if (thisScene == "C")
            forC();
            

        
        if (thisScene == "KA" && findHowmanywhite() == 1)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }


      
        if (thisScene == "D" && findHowmanywhite() == 1)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }
        if (thisScene == "E" && findHowmanywhite() == 1)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }






    }

    int findHowmanywhite()
    {
        count = 0;
        for (int i = 0; i < childnumber; i++)
        {
            if (this.transform.GetChild(i).GetComponent<Renderer>().material.GetColor("_Color") == defaultobj.GetComponent<Renderer>().material.GetColor("_Color"))
            {
                count++;
            }
        }
        //Debug.Log (count);
        return count;
    }


    int findhowmanywithTag(string Tagname)
    {
        counttag = 0;
        for (int i = 0; i < childnumber; i++)
        {
            if (this.transform.GetChild(i).GetComponent<Renderer>().material.GetColor("_Color") == defaultobj.GetComponent<Renderer>().material.GetColor("_Color")
                && this.transform.GetChild(i).tag == Tagname)
            {
                counttag++;
            }


        }
        return counttag;

    }

    IEnumerator waitanysecond(int sec)
    {
        completed.SetActive(true);
        yield return new WaitForSeconds(sec);
        if (thisScene == "Gha")
            SceneManager.LoadScene("Naag");
        if (thisScene == "GA")
            SceneManager.LoadScene("Gha");
        if (thisScene == "KHA")
            SceneManager.LoadScene("GA");
        if (thisScene == "KA")
            SceneManager.LoadScene("KHA");
        if (thisScene == "A")
            SceneManager.LoadScene("B");
        if (thisScene == "B")
            SceneManager.LoadScene("C");
        if (thisScene == "C")
            SceneManager.LoadScene("D");
        if (thisScene == "D")
            SceneManager.LoadScene("E");
    }


    void forkha()
    {

        if (thisScene == "KHA" && findHowmanywhite() == 0)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }


        if (findhowmanywithTag("Top") == 0)
        {

            FindObjectOfType<Kha>().firstorder = false;
            FindObjectOfType<Kha>().secondorder = true;
        }

        if (findhowmanywithTag("khaside") == 0 && FindObjectOfType<Kha>().secondorder)
        {

            FindObjectOfType<Kha>().firstorder = false;
            FindObjectOfType<Kha>().secondorder = false;
            FindObjectOfType<Kha>().thirdorder = true;
        }

    }


    void forga()
    {

        if (thisScene == "GA" && findHowmanywhite() == 0)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }


        if (findhowmanywithTag("Top") == 0)
        {

            FindObjectOfType<GA>().firstorder = false;
            FindObjectOfType<GA>().secondorder = true;
        }

        if (findhowmanywithTag("khaside") == 0 && FindObjectOfType<GA>().secondorder)
        {

            FindObjectOfType<GA>().firstorder = false;
            FindObjectOfType<GA>().secondorder = false;
            FindObjectOfType<GA>().thirdorder = true;
        }

    }


    void forgha()
    {
        if (thisScene == "Gha" && findHowmanywhite() == 0)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }


        if (findhowmanywithTag("khaside") == 0 && FindObjectOfType<Gha>().firstorder)
        {

            FindObjectOfType<Gha>().firstorder = false;
            FindObjectOfType<Gha>().secondorder = true;
            //FindObjectOfType<Gha>().thirdorder = false;
        }


        if (findhowmanywithTag("Top") == 0 && FindObjectOfType<Gha>().thirdorder)
        {

            FindObjectOfType<Gha>().firstorder = false;
            FindObjectOfType<Gha>().secondorder = false;

        }
        if (findhowmanywithTag("verticle") == 0 && FindObjectOfType<Gha>().secondorder)
        {

            FindObjectOfType<Gha>().firstorder = false;
            FindObjectOfType<Gha>().secondorder = false;
            FindObjectOfType<Gha>().thirdorder = true;
        }

    }

    void fornaa()
    {
        if (thisScene == "Naag" && findHowmanywhite() == 0)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }

        if (findhowmanywithTag("Top") == 0 && FindObjectOfType<Naag>().secondorder)
        {
            FindObjectOfType<Naag>().thirdorder = true;
            FindObjectOfType<Naag>().secondorder = false;
           
        }


        if (findhowmanywithTag("khaside") == 0 && FindObjectOfType<Naag>().firstorder)
        {
            FindObjectOfType<Naag>().secondorder = true;
            FindObjectOfType<Naag>().firstorder = false;
            FindObjectOfType<Naag>().thirdorder = false;

        }

        if (findhowmanywithTag("verticle") == 0 && FindObjectOfType<Naag>().thirdorder)
        {
            
            FindObjectOfType<Naag>().thirdorder = false;
           

        }




    }

    void forA()
    {

        if (thisScene == "A" && findHowmanywhite() == 1)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }
        if(findhowmanywithTag("firsttrace")==0 && FindObjectOfType<Ascript>().firstorder)
        {
            FindObjectOfType<Ascript>().secondorder = true;
            FindObjectOfType<Ascript>().firstorder = false;

        }
        if (findhowmanywithTag("secondtrace") == 0 && FindObjectOfType<Ascript>().secondorder)
        {
            FindObjectOfType<Ascript>().secondorder = false;
            FindObjectOfType<Ascript>().thirdorder = true;
        }
        if (findhowmanywithTag("thirdtrace") == 0 && FindObjectOfType<Ascript>().thirdorder)
        {
            FindObjectOfType<Ascript>().thirdorder = false;
        }
    }

    void forB()
    {

        if (thisScene == "B" && findHowmanywhite() == 1)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }

        if(findhowmanywithTag("verticle") ==0 && FindObjectOfType<BScript>().firstorder)
        {
            FindObjectOfType<BScript>().firstorder = false;
            FindObjectOfType<BScript>().secondorder = true;
        }

        if(findhowmanywithTag("firsttrace")==0 && FindObjectOfType<BScript>().secondorder)
        {
            FindObjectOfType<BScript>().secondorder = false;
            FindObjectOfType<BScript>().thirdorder = true;
        }

        if(findhowmanywithTag("secondtrace")==0 && FindObjectOfType<BScript>().thirdorder)
        {
            FindObjectOfType<BScript>().thirdorder = false;
            
        }
    }

    void forC()
    {
        if (thisScene == "C" && findHowmanywhite() == 1)
        {
            if (!audior.isPlaying)
                audior.Play();
            StartCoroutine(waitanysecond(1));
        }

        if(findhowmanywithTag("firsttrace")==0 && FindObjectOfType<CScript>().firstorder)
        {
            FindObjectOfType<CScript>().firstorder = false;
            FindObjectOfType<CScript>().secondorder = true;

        }

        if (findhowmanywithTag("secondtrace") == 0 && FindObjectOfType<CScript>().secondorder)
        {
            FindObjectOfType<CScript>().secondorder = false;
            FindObjectOfType<CScript>().thirdorder = true;

        }

        if (findhowmanywithTag("thirdtrace") == 0 && FindObjectOfType<CScript>().thirdorder)
        {
            FindObjectOfType<CScript>().thirdorder = false;

        }
    }







}

