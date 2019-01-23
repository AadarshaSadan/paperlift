using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public Stack<GameObject> numbers = new Stack<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        

        if (objects.Count == 1)
        {
            Debug.Log("total number of objects " + objects.Count);
        }
        for(int i=0;i<objects.Count;i++)
        {
            Debug.Log(objects[i].transform.position);
            numbers.Push(objects[i]);
        }

        GameObject nextObect = numbers.Pop();
        Debug.Log(nextObect.name);
        GameObject next = numbers.Pop();
        Debug.Log(next.name);

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
