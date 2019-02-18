using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handOnoff : MonoBehaviour
{
    /*public int count = 1;
    public GameObject hand;
    Animator incline_Animition_A;
    public bool Isstop;
    public GameObject temphand;*/
    public Camera thiscamra;
    public bool isOff;
    public Vector3 pos=new Vector3(0f,0.8f,-10.33f);


    public List<GameObject>allGameobject= new List<GameObject>(); 

   
    // Start is called before the first frame update
    void Start()
    {
        // incline_Animition_A = hand.GetComponent<Animator>();
        thiscamra.transform.position = pos;
        
    }

    // Update is called once per frame
    void Update()
    {
      //  Isstop = incline_Animition_A.GetBool("nowStop");
       /* if(incline_Animition_A.GetNextAnimatorStateInfo(0).IsName("idle"))
        {
            count++;
            hand.SetActive(true);
            temphand.SetActive(false);
        }*/

       

        if(!isOff)
        {
            for (int i = 0; i < allGameobject.Count; i++)
            {
                allGameobject[i].SetActive(true);
                thiscamra.transform.position = new Vector3(0f, 0.83f, -10.33f);

            }
        }
    }

    public void OnclickFitToScreen()
    {

        isOff = true;
        if (isOff)
        {
            for (int i = 0; i < allGameobject.Count; i++)
            {
                allGameobject[i].SetActive(false);
                thiscamra.transform.position = new Vector3(-2.78f, 2.13f, -7.92f);

            }
        }
    }


}
