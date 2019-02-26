using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    // Use this for initialization

        
    void Start()
    {
      
            
     }

    // Update is called once per frame
    void Update()
    {

    }


    public void mainplay()
    {
        SceneManager.LoadScene("Menu");
    }



    public void TOkA()
    {
        SceneManager.LoadScene("KA");
    }

    public void ToKHA()
    {
        SceneManager.LoadScene("KHA");
    }

    public void ToGA()
    {
        SceneManager.LoadScene("GA");
    }

    public void ToGha()
    {
        SceneManager.LoadScene("Gha");
    }

    public void ToNag()
    {
        SceneManager.LoadScene("Naag");
    }

    public void ToA()
    {
        SceneManager.LoadScene("A");
    }
    public void ToB()
    {
        SceneManager.LoadScene("B");
    }
    public void ToC()
    {
        SceneManager.LoadScene("C");
    }
    public void ToD()
    {
        SceneManager.LoadScene("D");
    }
    public void ToE()
    {
        SceneManager.LoadScene("E");
    }

    public void ToMatchthewordAR()
    {
        SceneManager.LoadScene("matchingAr2");

    }

    public void toAbc()
    {
        SceneManager.LoadScene("Abc");
    }


    public void ToAR()
    {
        SceneManager.LoadScene("Ar");

    }



    public void twodNepali()
    {
        SceneManager.LoadScene("Nepali2D");
    }

    public void VideoplayeR()
    {
        SceneManager.LoadScene("Videoplayer");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

 

}



