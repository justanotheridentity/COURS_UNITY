using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neverStop : MonoBehaviour
{

    Vector2 velocity;
    Rigidbody2D rbdy2;

	// Use this for initialization
	void Start ()
    {
        rbdy2 = this.GetComponent <Rigidbody2D>();
        velocity = new Vector2(-5000, 0);
        rbdy2.velocity = velocity;
    }
	
	// Update is called once per frame	
	void Update ()
    {
        velocity = new Vector2(Mathf.Clamp(rbdy2.velocity.x, -5000, 5000), Mathf.Clamp(rbdy2.velocity.y, -5000, 5000));
        rbdy2.velocity = velocity;


    }
}
