using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGO : MonoBehaviour {

    public float speed;
    public float numberAssign;


	// Use this for initialization
	void Start ()
    {
        //speed = Random.Range(1.0f, 5.0f);
	}
	
	// Update is called once per frame
	void FixedUpdate ()

    {
        transform.position += new Vector3(0.0f, 0.0f, -(speed * Time.fixedDeltaTime) )  ;
	}

    public void GoFast ()
    {

        StartCoroutine(GoFaster());

    }

    IEnumerator GoFaster()
    {
        transform.position += new Vector3(0.0f, 0.0f, -(speed*3 * Time.fixedDeltaTime));
        yield return new WaitForSeconds(3f);
        StartCoroutine(GoFaster());
    }

    public void SetNumber (int numberToSet)
    {
        numberAssign = numberToSet;
    }

}
