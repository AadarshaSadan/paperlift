using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumecontroll : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject mute;
    public GameObject unmute;
    AudioSource mainaudio;
    void Start()
    {
        unmute.SetActive(true);
        mute.SetActive(false);
        mainaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void unmutevolume()
    {
        mainaudio.Play();
        mute.SetActive(false);
        unmute.SetActive(true);
    }

    public void mutevolume()
    {
        mainaudio.Stop();
        mute.SetActive(true);
        unmute.SetActive(false);
    }
}
