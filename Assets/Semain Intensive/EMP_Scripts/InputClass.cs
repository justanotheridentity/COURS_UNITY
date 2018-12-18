using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow Was Pressed");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow Was Pressed");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Left Arrow Was Pressed");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Right Arrow Was Pressed");
        }

    }
}
