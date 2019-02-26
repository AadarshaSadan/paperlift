using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GUii : MonoBehaviour,IPointerEnterHandler
{
    public Texture homeTexture;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
      
        if (GUI.Button(new Rect(10,5,100,100),homeTexture))
        {
            Debug.Log(GUI.skin.button.hover.textColor);

        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
    }
}
