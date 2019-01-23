using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CScript : MonoBehaviour
{
    public Camera mainCamera;
    public bool firstorder;
    public bool secondorder;
    public bool thirdorder;

    // Start is called before the first frame update
    void Start()
    {
        firstorder = true;

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

                if (hitpoint.transform.gameObject.tag == "firsttrace" && firstorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                if (hitpoint.transform.gameObject.tag == "secondtrace" && secondorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                }

                if (hitpoint.transform.gameObject.tag == "thirdtrace" && thirdorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;

                }
            }

        }
    }
}
