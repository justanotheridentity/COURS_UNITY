using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementFun : MonoBehaviour
{

    
    // MOUVEMENT CERCLE
    public float RotateSpeed = 5f;
    public float Radius = 0.1f;

    private Vector2 _centre;
    public Transform PointDePivot;
    private float _angle;

    //MOUVEMENT JOYSICK
    private static string moveHorizontal = "Horizontal"; // recuperation des données de l'input manager
    private static string moveVertical = "Vertical";

    public float moveSpeed;

    private float moveAxisVertical;
    private float moveAxisHorizontal;


    private void Start()
    {
        MoveInCircle();



    }

    private void Update()
    {
        // on récupère les Input du joueur toutes les frames
        moveAxisVertical = Input.GetAxis(moveVertical) * moveSpeed;
        moveAxisHorizontal = Input.GetAxis(moveHorizontal) * moveSpeed;

        //Move Normale A ENLEVER
        //Move(moveAxisHorizontal * Time.fixedDeltaTime, moveAxisVertical * Time.fixedDeltaTime);
        // end
        Debug.Log(moveAxisHorizontal);
        Debug.Log(moveAxisVertical);


        if (Input.GetKey("space"))
        {

            Debug.Log(moveAxisHorizontal);
            Debug.Log(moveAxisVertical);
            PointDePivot.position = new Vector3(transform.position.x + moveAxisHorizontal, transform.position.y + moveAxisVertical, 0);
            
        }
    }


    private void FixedUpdate()
    {
        //if (!Input.GetKey(KeyCode.Space))
        
            MoveInCircle();
        
        
        
    }


    private void MoveInCircle ()
    {
        _centre = PointDePivot.transform.position;

        _angle += RotateSpeed * Time.deltaTime;

        Vector2 offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        transform.position = _centre + offset;
    }


    //A VIRER
    void Move(float x, float y)
    {
        transform.Translate(x, 0, 0);
        transform.Translate(0, y, 0);

    }



}
