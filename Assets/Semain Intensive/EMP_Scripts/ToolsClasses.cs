using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsClasses : MonoBehaviour {

    float initialTime;
    float deltaTime;

    // Use this for initialization
	void Start () 
    {
        initialTime = Time.time;
        deltaTime = initialTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Time elapsed : " + deltaTime);
        deltaTime += deltaTime + Time.deltaTime;
	}
}
