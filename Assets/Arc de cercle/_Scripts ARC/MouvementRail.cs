using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRail : MonoBehaviour
{

    
    // MOUVEMENT CERCLE
    public float RotateSpeed = 5f;
    public float Radius = 1f;

    private Vector2 _centre;
    public Transform PointDePivot;
    public Transform PointApercu;
    private float _angle;

    //MOUVEMENT JOYSICK
    private static string moveHorizontal = "Horizontal"; // recuperation des données de l'input manager
    private static string moveVertical = "Vertical";

    public float moveSpeed;

    private float moveAxisVertical;
    private float moveAxisHorizontal;

    private bool change = false;
    private Vector2 lastPos;
    private Vector2 increment;
    private Vector2 plusProche;
    private Vector2 incrementPlus;

    private float angleTest = 0;
    private float angleNouveu;
    

    private void Start()
    {
        



    }

    private void Update()
    {
        // on récupère les Input du joueur toutes les frames
        moveAxisVertical = Input.GetAxis(moveVertical) * moveSpeed;
        moveAxisHorizontal = Input.GetAxis(moveHorizontal) * moveSpeed;

        //Move Normale A ENLEVER
        //Move(moveAxisHorizontal * Time.fixedDeltaTime, moveAxisVertical * Time.fixedDeltaTime);
        // end
        


        if (Input.GetKey("space"))
        {

            PointApercu.position = new Vector3(transform.position.x + moveAxisHorizontal, transform.position.y + moveAxisVertical, 0);
            lastPos = transform.position;

        }

        if (Input.GetKeyUp("space"))
        {
            PointDePivot.position = PointApercu.position;
            change = true;
            Radius =  Vector2.Distance(PointApercu.position, transform.position);

        }

    }

    private void FixedUpdate()
    {
        //if (!Input.GetKey(KeyCode.Space)) d
        
            MoveInCircle();
        
        
        
    }


    private void MoveInCircle()
    {
        _centre = PointDePivot.transform.position;
        _angle += RotateSpeed * Time.deltaTime;
        Debug.Log(_angle);

        if (!change)
        {
            Vector2 offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
            Debug.Log(offset);
            transform.position = _centre + offset;
        }
        /*
        else if (change)
        {
            plusProche = new Vector2(PointDePivot.position.x +2* Radius, PointDePivot.position.y + 2 * Radius);
            angleTest = 0;

            for (float i =0; i < Radius; i = i+0.1f )
            {
                for (float a = 0; a < Radius; a = a + 0.1f)
                {
                    increment = new Vector2(Mathf.Cos (i),Mathf.Sin( a));
                    

                if (Vector2.Distance(_centre + increment,transform.position) < Vector2.Distance(plusProche, transform.position))
                    {
                        plusProche = _centre + increment;
                        incrementPlus = increment;
                        
                    }
                }


                    
            }

            Debug.Log(plusProche);

            transform.position = plusProche;
            Debug.Log("LeNOmbre:plusProche.x " + plusProche.x);
            Debug.Log(plusProche.x %1); //  /((Radius * RotateSpeed * 2) - 1)
            //_angle = Mathf.Acos(plusProche.x / (Radius * RotateSpeed )  ) ;
            //_angle = Mathf.Acos(plusProche.x%1)*(RotateSpeed*Radius);
            
            Debug.Log("WOOOOOOOOOOOOOOOOOOOOOOOOW  " + _angle);
            change = false;
        }*/
        else if (change)
        {
            float newRadius = Vector2.Distance(transform.position, PointDePivot.transform.position);

            float angle = 0;
            float closestDist = Mathf.Infinity;
            Vector2 closestPos = new Vector2();
            float closestAngle = 0;
            float dist;
            Vector2 pos;
            for (; angle < 2 * Mathf.PI; angle += 0.05f)
            {
                pos = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * newRadius + _centre;
                dist = Vector2.Distance(pos, transform.position);

                if (dist < closestDist)
                {
                    closestPos = pos;
                    closestDist = dist;
                    closestAngle = angle;
                }

            }

            _angle = closestAngle;
            transform.position = closestPos;
            change = false;
        }
    }


    //A VIRER
    void Move(float x, float y)
    {
        transform.Translate(x, 0, 0);
        transform.Translate(0, y, 0);

    }



}
