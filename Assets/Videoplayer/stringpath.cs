using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class stringpath : MonoBehaviour
{
    public bool isOk;
    // Start is called before the first frame update
 public VideoPlayer videoPlayer;
    private string path;
    public string temppath;
    public int s;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            if (isOk)
            {
                videoPlayer.url = temppath;
            }
        
    }

    

    public void openFile()
    {
        path = EditorUtility.OpenFilePanel("overite", "", "mp4");

        //file://A:/Study/Tutorial/Complete C# Unity 2D & 3D Game Development Masterclass 2018/Complete C# Unity 2D & 3D Game Development Masterclass 2018/[Tutsgalaxy.com] - Complete C# Unity 2D & 3D Game Development Masterclass 2018/1. Introduction/2. Who am I.mp4
       temppath="file://"+path;
        WWW thusurl = new WWW("file://" + path);
     


    }


}
