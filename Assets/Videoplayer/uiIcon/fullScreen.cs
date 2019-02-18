using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject>Showobj = new List<GameObject>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Debug.Log("hello");
        for(int i=0;i<Showobj.Count;i++)
        {
            Showobj[i].SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        Debug.Log("exit");
        for (int i = 0; i < Showobj.Count; i++)
        {
            Showobj[i].SetActive(false);
        }
    }

}

