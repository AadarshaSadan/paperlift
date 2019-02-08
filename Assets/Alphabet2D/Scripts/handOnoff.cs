using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handOnoff : MonoBehaviour
{
    public int count = 1;
    public GameObject hand;
    Animator incline_Animition_A;
    public bool Isstop;
    public GameObject temphand;

   
    // Start is called before the first frame update
    void Start()
    {
        incline_Animition_A = hand.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Isstop = incline_Animition_A.GetBool("nowStop");
        if(incline_Animition_A.GetNextAnimatorStateInfo(0).IsName("idle"))
        {
            count++;
            hand.SetActive(true);
            temphand.SetActive(false);
        }
    }

    
}
