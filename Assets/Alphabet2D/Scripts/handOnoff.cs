using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handOnoff : MonoBehaviour
{
    /*public int count = 1;
    public GameObject hand;
    Animator incline_Animition_A;
    public bool Isstop;
    public GameObject temphand;*/


    public Camera thiscamra;
    public GameObject RightPanel;

    public GameObject fullscreebbutton;
    public GameObject smallscreenbutton;

    public GameObject quad;
    public GameObject home_btn;






    // Start is called before the first frame update
    void Start()
    {
        // incline_Animition_A = hand.GetComponent<Animator>();
        thiscamra.transform.position = new Vector3(1.2f, 1.6f, -28.2f);

    }

    // Update is called once per frame
    void Update()
    {




    }

    public void OnclickFitToScreen()
    {


        FindObjectOfType<Videoscroll>().isFullscreenClick = true;



        fullscreebbutton.SetActive(false);
        smallscreenbutton.SetActive(true);
        quad.SetActive(false);
        RightPanel.SetActive(false);
        home_btn.SetActive(false);


    }


    public void reduce_screensize()
    {
        FindObjectOfType<Videoscroll>().isFullscreenClick = false;
        smallscreenbutton.SetActive(false);
        fullscreebbutton.SetActive(true);
        quad.SetActive(true);
        RightPanel.SetActive(true);
        home_btn.SetActive(true);

    }




}
