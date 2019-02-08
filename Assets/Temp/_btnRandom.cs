using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class _btnRandom : MonoBehaviour
{
    AudioSource source;
    public AudioClip rightaudio;
    public AudioClip wrongaudio;
    public bool isPlayaudio;

    public bool isanotheraudio;
    // Start is called before the first frame update
    public GameObject righttext;

    public GameObject wrongtext;
    public List<GameObject> objectAr = new List<GameObject>(); //gameobject from AR imagetarget


    public Text thisisText;
    public List<string> list = new List<string>();//list of words alphabhet A-Z like apple,ball...zebra 
    List<string> nameList = new List<string>();
    public List<Text> uitext = new List<Text>();//text from number of button
    int curCount = 0;

    public string buttonText;

    public int temp = 99;//temporary values not in range number of button

    public int btn = 100;//temporary value not in range number of buttion any number



    [SerializeField]
    private bool isfirstbutton = false;

    //for next card message display
    public GameObject msg;

    //message for timer object
    public GameObject timermsg;

    public float timeLeft = 30.0f;//STOPWatch time

    //public List<string>
    void Start()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>(); //get audio sources 
        source = audioSources[0];
        rightaudio = audioSources[0].clip;
        // wrongaudio = audioSources[1].clip;
        nameList.Clear();
        curCount = 0;
        //this show first random alphabet in button,
        while (nameList.Count < 5)
        {
            int itemIndex = Random.Range(0, list.Count);

            if (checkDuplicate(list[itemIndex]) == false)
            {
                nameList.Add(list[itemIndex]);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            uitext[i].text = nameList[i];
        }
        ///
    }

    // Update is called once per frame
    void Update()
    {
        Timer();

        if (isPlayaudio)
        {
            if (isPlayaudio)
            {
                source.PlayOneShot(rightaudio);


            }
            isPlayaudio = false;
        }

        if (isanotheraudio)
        {
            source.PlayOneShot(wrongaudio);
            isanotheraudio = false;
        }



        if (Input.GetMouseButtonDown(1))
        {
            temp = 50;
            righttext.SetActive(false);
            msg.SetActive(false);
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





            for (int i = 0; i < 5; i++)
            {
                uitext[i].text = nameList[i];
            }

        }


        //check if button index is equal to list list element  position in integer value
        //also check the object is shown from AR imagetarget
        if (btn == temp)//for second imagetarget
        {
            if (objectAr[1].activeSelf)//for second imagetarget eg:-ball
            {
                isfirstbutton = true;
                isPlayaudio = true;
                righttext.SetActive(true);
                list.Remove("ball");
            }

            if (objectAr[0].activeSelf) //for  first image target eg:-apple
            {
                isfirstbutton = true;
                isPlayaudio = true;
                righttext.SetActive(true);
                list.Remove("apple");
            }

            if (objectAr[4].activeSelf)
            {
                isfirstbutton = true;
                righttext.SetActive(true);
            }

        }
        else
        {
            isfirstbutton = false;
            // righttext.SetActive(false);
        }


        displayMsgIfAlreadyshown();


    }





    public void firstbutton()
    {
        btn = 0;
        if (objectAr[0].activeSelf)
        {
            isPlayaudio = true;
            Debug.Log("Right");
        }
        else
        {
            isanotheraudio = true;
            Debug.Log("wrong");
        }



    }

    public void secondbutton()
    {
        btn = 1;
    }

    public void thirdbutton()
    {
        btn = 2;
    }

    public void fourthbutton()
    {
        btn = 3;

    }
    public void fifthbutton()
    {
        btn = 4;
    }

    public void Getallbutton()
    {
        buttonText = EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text; //get text from list of button



        for (int i = 0; i < 5; i++)
        {
            if (objectAr[1].activeSelf)
            {
                if (uitext[i].text == "ball")
                {
                    temp = i;

                }
            }

            if (objectAr[0].activeSelf)
            {
                if (uitext[i].text == "apple")
                {
                    temp = i;

                }
            }
            if (objectAr[4].activeSelf)
            {
                if (uitext[i].text == "elephant")
                {
                    temp = i;

                }
            }


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
    

    private void displayMsgIfAlreadyshown()
    {

        if (objectAr[1].activeSelf && !list.Contains("ball"))
        {
            msg.SetActive(true);
        }

        if (objectAr[0].activeSelf && !list.Contains("apple"))
        {
            msg.SetActive(true);
        }


        if (objectAr[4].activeSelf && !list.Contains("elephant"))
        {
            msg.SetActive(true);
        }




    }


    public void ResetRandomList()
    {
        temp = 50;
        righttext.SetActive(false);
        msg.SetActive(false);
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





        for (int i = 0; i < 5; i++)
        {
            uitext[i].text = nameList[i];
        }
    }


    private void Timer()
    {

        if (!objectAr[0].activeSelf || !objectAr[1].activeSelf || !objectAr[2].activeSelf || !objectAr[3].activeSelf || !objectAr[4].activeSelf)
        {
            
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                
                timeLeft = 8;
                timermsg.SetActive(true);
            }
            
        }
        else
        {
            timermsg.SetActive(false);
            timeLeft = 8;
        }
        if (objectAr[0].activeSelf || objectAr[1].activeSelf || objectAr[2].activeSelf || objectAr[3].activeSelf || objectAr[4].activeSelf)
        {

         
                timermsg.SetActive(false);
            

        }
    }
}
