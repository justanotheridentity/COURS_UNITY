using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
    public Color color;
    public Toggle keepIconLighted;
    public Text livesText;

    Image image;
    Color colorSaved;
    

	// Use this for initialization
	void Start ()
    {
        image = GetComponent<Image>();
        colorSaved = image.color;
	}
	
	// Update is called once per frame	
	void Update ()
    {
		
	}

    public void OnIconEnter ()
    {
        image.color = color;
    }

    public void OnIconExit()
    {
        image.color = colorSaved;
    }

}
