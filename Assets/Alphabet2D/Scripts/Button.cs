using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//Button Script
public class Button : MonoBehaviour
{
		[HideInInspector]
		public bool isBegan;
		public Type type = Type.NORMAL;
		public ToggleStatus toggleStatus = ToggleStatus.ON;
		public Sprite normalIcon;
		public Sprite hoverIcon;
		public AudioClip clickReleaseSFx;
		public string message;
		public bool resetIconOnRelease = true;
		public SpriteRenderer spriteRendererComp;
		public Object messageObject;
    internal ColorBlock colors;

    void Awake ()
		{
				this.tag = "UIButton";
		}

		void Start ()
		{
				if (messageObject == null) {
					messageObject = gameObject;
				}
				spriteRendererComp = GetComponent<SpriteRenderer> ();
		}

		public enum Type{
				NORMAL,
				TOGGLE
    	}
		;

		public enum ToggleStatus
		{
				ON,
				OFF
	    }
		;
}
