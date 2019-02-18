using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkActivity : MonoBehaviour

{

    public List<GameObject>imageTargetGameObject= new List<GameObject>();
    public List<GameObject>alphabetText = new List<GameObject>();
    public int thisdata;
    public GameObject hideData;
    public GameObject unhidData;
    public bool offdata=true;
    // Start is called before the first frame update
    void Start()
    {
        offdata = true;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0;i<imageTargetGameObject.Count;i++)
        {
            if(imageTargetGameObject[i].activeSelf)
            {
                if (offdata)
                {
                    alphabetText[i].SetActive(true);

                    thisdata = i;
                }
                if(!offdata)
                {
                    alphabetText[i].SetActive(false);
                }
            }
            else
            {
                alphabetText[i].SetActive(false);
            }
           
        }

        


        
    }


    public void hidethisactiveScene()
    {

        offdata = false;
        unhidData.SetActive(true);
        hideData.SetActive(false);
    }

  
    public  void unhideactiveScene()
    {
        offdata = true;
        hideData.SetActive(true);
        unhidData.SetActive(false);

        alphabetText[thisdata].SetActive(false);
    }


}
