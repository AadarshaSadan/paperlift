using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Videoprogress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler //,IDragHandler
{
    // Start is called before the first frame update
    private Image progressbar;
    public Slider volume;
    public float fromSlider;

    public Slider playerslider;
    public VideoPlayer videoplayer;
    private float timer = 0.00000001f;

    public Text currentminute;
    public Text currentsecond;
    public Text TotalMinute;
    public Text TotalSecond;
    private bool slide=false;

    private void Start()
    {

        volume.value = 0.24f;
        videoplayer.targetTexture.Release();
       // playerslider=GetComponent<Slider>();
    }

    private void Awake()
    {
        progressbar = GetComponent<Image>();



    }


    // Update is called once per frame
    void Update()
    {
           videoplayer.SetDirectAudioVolume(0, volume.value);
               if (videoplayer.frameCount > 0)
               {
                   progressbar.fillAmount = (float)videoplayer.frame / (float)videoplayer.frameCount;
                  // playerslider.value = (float)videoplayer.frame / (float)videoplayer.frameCount;
               }

               if (videoplayer.isPlaying)
               {
                   CurrentTime();
               }

               if (!slide && videoplayer.isPlaying)
               {
                   playerslider.value = (float)videoplayer.frame / (float)videoplayer.frameCount;
               }

     }



        public void OnDrag(PointerEventData eventData)
        {
            TrySkip(eventData);
       

        }
        public void OnPointerUp(PointerEventData eventData)
        {

        }



        public void OnPointerDown(PointerEventData eventData)
        {
            TrySkip(eventData);
            slide = true;

        }

        private void TrySkip(PointerEventData eventData)
        {
            Vector2 localPoint;
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(progressbar.rectTransform, eventData.position, null, out localPoint))
            {
                float pct = Mathf.InverseLerp(progressbar.rectTransform.rect.xMin, progressbar.rectTransform.rect.xMax, localPoint.x);
                SkipToPercentage(pct);
            }
        }

        private void SkipToPercentage(float pct)
        {
            var frame = videoplayer.frameCount * pct;
            videoplayer.frame = (long)frame;
        }
    

    private void CurrentTime()
    {
        string minutes = Mathf.Floor((int)videoplayer.time / 60).ToString("00");
        string seconds = ((int)videoplayer.time % 60).ToString("00");
        currentminute.text = minutes;
        currentsecond.text = seconds;
    }

    public void TotalTime()
    {
        string minutes = Mathf.Floor((int)videoplayer.clip.length / 60).ToString("00");
        string seconds = ((int)videoplayer.clip.length % 60).ToString("00");
        TotalMinute.text = minutes;
        TotalSecond.text = seconds;
    }

}
