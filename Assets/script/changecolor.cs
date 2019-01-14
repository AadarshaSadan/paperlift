using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour {
   public  bool changeit;
    public Component[] Renderer;

    
    // Use this for initialization
    void Start () {
      //  Renderer = GetComponentInChildren<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
        if(changeit)
        {
            for (int i = 0; i < this.transform.childCount; i++)
            {

                this.transform.GetChild(i).GetComponent<Renderer>().material.color = Color.blue;
                //gameobj.transform.GetChild(i).m_render.material.color = Color.white;


            }

        }
	}
}
