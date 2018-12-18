using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleOther : MonoBehaviour {

    public int degreesPerSecond = 1 ;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.localPosition = Quaternion.AngleAxis(degreesPerSecond * Time.deltaTime, Vector3.forward) * transform.localPosition;
    }
}
/*var target : Transform; // drop what you want the satellite to rotate around here in the inspector
 var orbitSpeed : float = 10.0;
  
 function Update()
{
    transform.RotateAround(target.position, Vector3.up, orbitSpeed * Time.deltaTime);
}
*/