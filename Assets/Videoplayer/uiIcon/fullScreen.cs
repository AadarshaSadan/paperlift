using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fullScreen : MonoBehaviour
// Start is called before the first frame update
{ 
    public List<GameObject> Showobj = new List<GameObject>();
    public GameObject smallscreenbutton;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnMouseOver()
    {
        if (FindObjectOfType<Videoscroll>().isFullscreenClick)
        {
            for (int i = 0; i < Showobj.Count; i++)
            {
                Showobj[i].SetActive(true);
            }

        }
    }


    private void OnMouseExit()
    {
        if (FindObjectOfType<Videoscroll>().isFullscreenClick)
        {
            for (int i = 0; i < Showobj.Count; i++)
            {
                {
                    Showobj[i].SetActive(false);
                }

            }
        }
    }


}

