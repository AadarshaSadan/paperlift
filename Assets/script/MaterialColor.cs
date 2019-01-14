using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColor : MonoBehaviour {

    Camera mainCamera;
    MeshRenderer M_render;
	// Use this for initialization
	void Start () {
        M_render = GetComponent<MeshRenderer>();	
	}
	
	// Update is called once per frame
	void Update () {
      
        

	}

    private void OnMouseOver()
    {
       if(FindObjectOfType<GameController>().isAlright)
        {
           // M_render.material.color = Color.red;
        }
    }

    private void OnMouseExit()
    {
        //FindObjectOfType<GameController>().isAlright = false;
    }

    public void materialChange(MeshRenderer m_rend)
    {
        M_render = m_rend;
        
    }
}
