using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RandomGenerator : MonoBehaviour
{
    public Text thisisText;
    public List<string> list = new List<string>();
    List<string> nameList = new List<string>();
    public List<Text>uitext = new List<Text>();
    int curCount = 0;
    private string display = "This";
  

    void Start()
    {
        nameList.Clear();
        curCount = 0;


        thisisText.text = display;

       

        
    }

    void Update()
    {
       
         

        if (Input.GetMouseButtonDown(1))
        {
            curCount = 0;
            nameList.Clear();
          
            while (nameList.Count < 5)
            {
                int itemIndex = Random.Range(0, list.Count);

                if (checkDuplicate(list[itemIndex]) == false)
                {
                    nameList.Add(list[itemIndex]);
                }
            }


          


            for(int i=0;i<5;i++)
            {
                uitext[i].text = nameList[i];
            }
           /*foreach (string name in nameList)
            {
              
                    uitext[].text = name;
                
             }*/
        }
    }




    bool checkDuplicate(string str)
    {
        int tempCount = 0;

        foreach (string temp in nameList)
        {
            if (temp.Substring(0, 1) == str.Substring(0, 1))
            {
                tempCount++;
            }
        }

        if (tempCount == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}