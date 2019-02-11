using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Videoprogress : MonoBehaviour,IDragHandler,IPointerDownHandler
{
    // Start is called before the first frame update
    private Image progressbar;
    public Slider volume;

    public VideoPlayer videoplayer;
    private float timer = 0.00000001f;
    private void Awake()
    {
        progressbar = GetComponent<Image>();

        //videoplayer.GetDirectAudioVolume = 0.5f;
    }
  

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;

        // progressbar.fillAmount = timer;


        if (videoplayer.frameCount > 0)
            progressbar.fillAmount = (float)videoplayer.frame / (float)videoplayer.frameCount;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    private void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(progressbar.rectTransform,eventData.position,null,out localPoint))
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
}
