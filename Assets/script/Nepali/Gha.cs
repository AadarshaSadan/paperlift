using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gha : MonoBehaviour
{
    public bool firstorder;
    public bool secondorder;
    public bool thirdorder;
    public Camera mainCamera;

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

                if (hitpoint.transform.gameObject.tag == "Top" && thirdorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                    Debug.Log("from top");
                }
                if (hitpoint.transform.gameObject.tag == "khaside" && firstorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                }

                if (hitpoint.transform.gameObject.tag == "verticle" && secondorder)
                {

                    hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.red;

                }
            }

        }
    }
}
