using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Naag : MonoBehaviour
{
    public Camera mainCamera;
    // Start is called before the first frame update
    public bool firstorder;
    public bool secondorder;
    public bool thirdorder;

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

                if (hitpoint.transform.gameObject.tag == "Top" && secondorder)
                {
                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                }

                if (hitpoint.transform.gameObject.tag == "khaside" && firstorder)
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
