using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidetext : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject GameController;
    public GameObject textgameobjectl;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void hide_text()
    {
        GameController.GetComponent<checkActivity>().enabled = false;
        textgameobjectl.SetActive(false);


    }
}
