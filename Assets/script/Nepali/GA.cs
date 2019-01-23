using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GA : MonoBehaviour
{

    public Camera mainCamera;
    public bool firstorder;
    public bool secondorder;
    public bool thirdorder;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitpoint;
        if (Physics.Raycast(ray, out hitpoint))
        {

            if (hitpoint.collider.name != "wallpaper")
            {

                if (hitpoint.transform.gameObject.tag == "Top" && firstorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                if (hitpoint.transform.gameObject.tag == "khaside" && secondorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                }

                if (hitpoint.transform.gameObject.tag == "verticle" && thirdorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;

                }
            }

        }




    }
}
