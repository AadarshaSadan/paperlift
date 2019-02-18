using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;
public class Videoscroll : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> thumbnail = new List<GameObject>();
    public List<VideoClip> videoClip = new List<VideoClip>();
    public VideoPlayer videoplayer;
    public Text currentVideoTitle;
    public string _getalldata;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Getallbtn()
    {
        _getalldata = EventSystem.current.currentSelectedGameObject.transform.name.ToString();

        try
        {

            for (int i = 0; i < 10; i++)
            {
                if (_getalldata == "btn" + i.ToString())
                {
                    videoplayer.clip = videoClip[i];
                    videoplayer.Play();
                    FindObjectOfType<Videoprogress>().TotalTime();
                    currentVideoTitle.text = videoClip[i].name.ToString();
                }


            }
        }catch(Exception e)
        {
            Debug.Log("error in this block ignored");
        }
    }
    


   
}
