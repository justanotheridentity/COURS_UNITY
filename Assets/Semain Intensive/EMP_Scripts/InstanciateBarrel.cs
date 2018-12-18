using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateBarrel : MonoBehaviour 
{

    public Transform barrel;
    public Transform initialPosition;


    // Use this for initialization
    void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(barrel, new Vector3(initialPosition.position.x, initialPosition.position.y, initialPosition.position.z), Quaternion.identity);
    }

    /*
    private void OnTriggerStay2D(Collider2D collision)
    {
        Instantiate(barrel, new Vector3(initialPosition.position.x, initialPosition.position.y, initialPosition.position.z), Quaternion.identity);
    }
    */
}
