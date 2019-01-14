using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KAScript : MonoBehaviour
{

    //set 3 point if it cross all three point set    
    public Camera mainCamera;
    public GameObject checkpoint1;
    public GameObject checkpoint2;
    public GameObject checkpoint3;
    public GameObject checkpoint4;
    public GameObject checkpoint5;

    private bool onepoint;
    private bool secondpoint;
    private bool thirdpoint;

    public bool straightline;
    public bool curveline;
    public bool topline;

    // Use this for initialization
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
            // hitpoint.collider.GetComponent<MaterialColor>().materialChange(hitpoint.collider.GetComponent<Renderer>());
            if (hitpoint.collider.name != "wallpaper" && hitpoint.transform.parent.name == "Straightline" && straightline)
            {
                hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
            }

            if (hitpoint.collider.name != "wallpaper" && hitpoint.transform.parent.name == "curvepart" && curveline)
            {
                hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
            }
            if (hitpoint.collider.name == checkpoint1.name)
            {
                onepoint = true;
            }
            if (hitpoint.collider.name == checkpoint2.name && onepoint)
            {
                secondpoint = true;
            }
            if (hitpoint.collider.name == checkpoint5.name && secondpoint || hitpoint.collider.name == checkpoint4.name && secondpoint)
            {
                FindObjectOfType<changecolor>().changeit = true;
            }
            if (hitpoint.collider.name != "wallpaper" && hitpoint.transform.parent.name == "Topline" && topline)
            {
                hitpoint.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }

    }
}
