using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayBtn : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite Sprite1;
    public Sprite Sprite2;

    public Sprite Spriteball1;
    public Sprite Spriteball2;

    public GameObject imageone;
    public GameObject imagetwo;
    private SpriteRenderer spriteRenderer;
    Image i_image;
    Image i_image_ball;

    public GameObject imagetarget1;
    public GameObject imagetarget2;

    public Camera arcamera;
    void Start()
    {
        i_image = imageone.GetComponent<Image>();
        i_image_ball = imagetwo.GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray = arcamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
            }
        }

        if (imagetarget1.activeSelf)
        {
            i_image.sprite = Sprite2;
        }

        if (!imagetarget1.activeSelf)
        {
            i_image.sprite = Sprite1;
        }
        if (imagetarget2.activeSelf)
        {
            i_image_ball.sprite = Spriteball1;
        }

        if (!imagetarget2.activeSelf)
        {
            i_image_ball.sprite = Spriteball2;
        }



    }

}
