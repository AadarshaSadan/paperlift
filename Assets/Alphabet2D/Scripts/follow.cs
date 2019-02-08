using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform current;
    public Transform target;
    [Range(0.0f, 10f)]
    public float speed = 3.93f;
    public bool isMoving;
    private Transform defaultpos;

    void Start()
    {
       // defaultpos.transform.position = current.transform.position;
    }

    void Update()
    {

        if (isMoving)
        {
            if (target.gameObject.activeSelf)
            {
                current.transform.position = Vector3.MoveTowards(current.position, target.position, speed * Time.deltaTime);
                current.transform.LookAt(target);
            }
        }
        if (!isMoving)
        {
           // current.transform.position = defaultpos.transform.position;
        }
    }



}



