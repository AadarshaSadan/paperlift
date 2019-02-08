using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class strManu : MonoBehaviour
{
    public bool isConnected;
    public GameObject Elephant;   

    public List<Text>myitmes=new List<Text>();


    IEnumerator checkInternetConnection(Action<bool> action)
    {
        WWW www = new WWW("http://google.com");
        yield return www;
        if (www.error != null)
        {
            action(false);
        }
        else
        {
            action(true);
              isConnected = true;
        }
    }



    List<string> objstring;
    // Start is called before the first frame update





 
    void Start()
    {
        objstring = new List<string> { "apple", "aeroplane", "Ball", "cat", "dog", "car", "egg", "elephant", "bus", "elephant" };
        StartCoroutine(checkInternetConnection((isConnected) => {
           
        }));
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            //string anotherstr = objstring[Random.Range(0, objstring.Count)];
            //string thirdone= objstring[Random.Range(0, objstring.Count)];
            for (int i = 1; i <=5; i++)
            {
               // string randomListString = objstring[Random.Range(0, objstring.Count)];
                //Debug.Log(randomListString);
            }

        }
    }

    void getrandom()
    {

    }
}
