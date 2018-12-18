using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CALMDOWN : MonoBehaviour {


    public float maxValue = 1000;
    Vector2 velocity;
    Rigidbody2D rbdy2;

	// Use this for initialization
	void Start ()
    {
        rbdy2 = this.GetComponent <Rigidbody2D>();
	}
	
	// Update is called once per frame	
	void Update ()
    {
        velocity = new Vector2(Mathf.Clamp(rbdy2.velocity.x, -maxValue, maxValue), Mathf.Clamp(rbdy2.velocity.y, -maxValue, maxValue));
        rbdy2.velocity = velocity;

        Debug.Log(velocity);
	}
}
