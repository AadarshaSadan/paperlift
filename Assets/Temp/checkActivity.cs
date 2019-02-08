using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkActivity : MonoBehaviour

{
    public GameObject PanelOn;
    public GameObject apple;
    public GameObject ball;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        PanelOn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(apple.activeSelf)
        {
           // Debug.Log("apple");
            PanelOn.SetActive(true);
        }

        if(!apple.activeSelf)
        {
            PanelOn.SetActive(false);
        }

        if(ball.activeSelf)
        {

        }
        if(car.activeSelf)
        {

        }
        
    }
}
