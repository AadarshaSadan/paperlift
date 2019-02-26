using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    // Start is called before the first frame update
    public Text logshow;
    public Camera forraycastCamera;
    private string textfromraycast; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = forraycastCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
           
        }
    }
}
