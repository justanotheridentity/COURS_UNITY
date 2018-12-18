using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProf : MonoBehaviour {


    int[][] tableau  = new int [2][];

    [SerializeField] private float maxSpeed = 0.2f;

    private Rigidbody2D rigidbody;
    private bool bFacingRight;
    private bool bKinematic = false;

	// Use this for initialization
	void Start ()
    {
        // tableau[0] = new Queue int [8];

        Queue<int>[] tableau = new Queue<int>[2];

        for (int i = 0; i < tableau.Length; i++)
        { tableau[i] = new Queue<int>(); }
        tableau[0].Enqueue(1);
        tableau[1].Enqueue(3);


        transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);

        bFacingRight = true;

        rigidbody = GetComponent<Rigidbody2D>();

        if (rigidbody.bodyType == RigidbodyType2D.Kinematic )
        {
            bKinematic = true;
        }
        

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        if (bKinematic)
        {
            rigidbody.velocity = new Vector2(moveX * maxSpeed, moveY * maxSpeed);
        }
        else
        {
            rigidbody.velocity = new Vector2(moveX * maxSpeed, rigidbody.velocity.y);
        
        }

        if ((moveX > 0 && !bFacingRight) || moveX < 0 && bFacingRight)
        {
            FlipSprite();
        }

        
    }

    void FlipSprite()
    {
        bFacingRight = !bFacingRight;
        Vector3 spriteLocalScale = transform.localScale;
        spriteLocalScale.x *= -1;
        transform.localScale = spriteLocalScale;
    }




}
