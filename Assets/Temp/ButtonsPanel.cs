using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonsPanel : MonoBehaviour, IPointerEnterHandler
{
    // Start is called before the first frame update
    AudioSource thisaudio;
    void Start()
    {
        thisaudio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnPointerEnter(PointerEventData eventData)
    {

            thisaudio.Play();
            Debug.Log("mouse");
        
    }
}
