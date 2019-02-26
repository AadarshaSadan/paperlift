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
    [Range(0, 500)]
    public int frameCur;
    public bool isVideoframe;

    public Camera _mainCamera;
    public float slider;
    public float slider_current;
    public bool isClick;
    public List<GameObject> thumbnail = new List<GameObject>();
    public List<VideoClip> videoClip = new List<VideoClip>();
    public VideoPlayer videoplayer;
    public bool isFullscreenClick;
    public Text currentVideoTitle;
    public string _getalldata;

    public RenderTexture abc;
    public GameObject videopauseBtn;
    public GameObject videoplayBtn;

    void Start()
    {
        videoplayBtn.SetActive(false);
        videopauseBtn.SetActive(true);


        // VideoPlayer automatically targets the camera backplane when it is added
        // to a camera object, no need to change videoPlayer.targetCamera.
        GameObject camera = GameObject.Find("Main Camera");

       var Videoplayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();
        
    }

    // Update is called once per frame
    void Update()
    {


        if (isFullscreenClick)
        {

            videoplayer.renderMode=UnityEngine.Video.VideoRenderMode.CameraNearPlane;

        }
        if(!isFullscreenClick)
        {
            videoplayer.renderMode = UnityEngine.Video.VideoRenderMode.RenderTexture;


        }

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
                    videoplayer.Prepare();
                    if (videoplayer.isPrepared)
                    {
                        videoplayer.Play();
                    }
                    FindObjectOfType<Videoprogress>().TotalTime();
                    currentVideoTitle.text = videoClip[i].name.ToString();
                
                
                }


            }
        }
        catch (Exception e)
        {
            Debug.Log("error in this block ignored");
        }
    }


    private void OnGUI()
    {
        // DoPlaybackControls();
       
    }

   /* void DoPlaybackControls()
    {
        // show the Play/Stop button
        if (GUI.Button(new Rect(0, Screen.height - 40, 40, 40), isClick ? "||" : ">"))
        {
            isClick = !isClick;
        }


        if (isClick)
            videoplayer.Play();
        if (!isClick)
            videoplayer.Pause();
       
        slider = videoplayer.frame;
        slider = GUI.HorizontalSlider(new Rect(50, Screen.height - 20, Screen.width - 60, 20), slider, 0, videoplayer.frameCount);
         videoplayer.frame = (int)slider;

    }*/


    public void Pause_()
    {
        if (videoplayer.isPlaying)
        {
            videoplayer.Pause();
            videoplayBtn.SetActive(true);
            videopauseBtn.SetActive(false);
        }

    }

    public void Play_()
    {
        
        videoplayer.Prepare();
        if (videoplayer.isPrepared)
        {
            videoplayer.Play();
            videoplayBtn.SetActive(false);
            videopauseBtn.SetActive(true);
        }

    }



}
