using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Mouvement : MonoBehaviour
{

    private static string moveHorizontal = "Horizontal"; // recuperation des données de l'input manager
    private static string moveVertical = "Vertical";

    public float moveSpeed;

    float moveAxisVertical;
    float moveAxisHorizontal;

    void Update() // on récupère les Input du joueur toutes les frames
    {
        moveAxisVertical = Input.GetAxis(moveVertical) * moveSpeed;
        moveAxisHorizontal = Input.GetAxis(moveHorizontal) * moveSpeed;
    }

    void FixedUpdate() // on applique avec un temps fixe les valeur a la fonction move
    {
        Move(moveAxisHorizontal * Time.fixedDeltaTime, moveAxisVertical * Time.fixedDeltaTime);
    }

    void Move(float x, float y)
    {
        transform.Translate(x, 0, 0);
        transform.Translate(0, y, 0);

    }
}