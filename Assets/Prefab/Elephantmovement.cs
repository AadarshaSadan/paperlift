using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elephantmovement : MonoBehaviour
{
    Animator elephant;
    public bool walkElephant;
    public GameObject _elephant;
    public Transform _apple;
    private Vector3 starpos;
    private Vector3 endpos;
    public GameObject target;

    private float lerptime = 10f;
    private float currentlerptime;


    // Start is called before the first frame update
    void Start()
    {
        elephant = _elephant.GetComponent<Animator>();
        starpos = _elephant.transform.position;
        endpos = _apple.position;
      //  Debug.Log("startposition" + endpos);
        elephant.SetBool("iswalking", false);

        // Calculate the journey length.

    }

    // Update is called once per frame
    void Update()
    {


       

        if (target.activeSelf)
        {
            currentlerptime += Time.deltaTime;
          
            if (currentlerptime >= lerptime)
            {
                currentlerptime = lerptime;
            }

            float per = currentlerptime / lerptime;
            _elephant.transform.position = Vector3.Lerp(starpos, endpos, per);
        }


    }


   



}
