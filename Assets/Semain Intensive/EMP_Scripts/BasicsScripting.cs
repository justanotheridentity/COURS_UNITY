using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicsScripting : MonoBehaviour 
{
    //public string customText = "Hello World : ";

    private string customText = "Hello World : ";
    private int iCounter = 0;

    void Awake()
    {
        Debug.Log("Awake : Hello ");
        //print("Awake : Hello ");
    }

    // Use this for initialization
    void Start () 
    {
        Debug.Log("Start : World ;)");
        //print("Start : World ;)");
    }
	
	// Update is called once per frame
	void Update ()
    {
        // See how it is collpase in console Window
        Debug.Log(customText + iCounter);
        //iCounter++;
	}
}
