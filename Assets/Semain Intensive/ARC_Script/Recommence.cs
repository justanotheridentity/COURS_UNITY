using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recommence : MonoBehaviour {

    public int [] PositionDesCubes;
    
    private string myString;

    private string aAfficher;
   

    private string numero;

    public GameObject depart;

    public int nbCube;

    //private int[] tableau;

    List<int> listNumber = new List<int>();


    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.gameObject != null)
        {
            if (other.transform.parent.gameObject.name == "Ligne") // other =
            {
                other.gameObject.transform.position = new Vector3(depart.gameObject.transform.position.x, depart.gameObject.transform.position.y, depart.gameObject.transform.position.z);

                //other.gameObject.GetComponent<BlockGO>().GoFast();

                //On executé la fonction avance rapide de l'objet.
            }
        }

        // On prend un cliché du tableau
        
        numero = other.gameObject.tag;
        Debug.Log(numero);
        int numeroGameObject = int.Parse(numero);

        



        for (int i=1; i<nbCube+1;i++)
        {
            listNumber.Add(i);
        }
        


        Cliche(numeroGameObject);
            

        
        aAfficher = "";

        for (int b= 0; b<10 ; b =b+1)
        {
             myString= PositionDesCubes[b].ToString();
            
            aAfficher = aAfficher + "-" + myString; ;


        }
        Debug.Log(aAfficher );

        aAfficher = "";
        for (int b = 0; b < 10; b = b + 1)
        {
            myString = listNumber[b].ToString();

            aAfficher = aAfficher + "-" + myString; ;


        }
        Debug.Log(aAfficher);

    }


    private void Cliche (int numeroGO)
    {
        int caseNumber = numeroGO - 1;
        for (int i=0; i<nbCube;i++)
        {
            PositionDesCubes[i] = listNumber [caseNumber] ;
            //Debug.Log(tableau[caseNumber]);
            if(caseNumber==nbCube-1)
            {
                caseNumber = 0;
            }
            else
            {
                caseNumber++;
            }
        }
    }
}
