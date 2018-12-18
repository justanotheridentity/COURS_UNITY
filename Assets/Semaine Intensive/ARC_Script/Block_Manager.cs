using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Manager : MonoBehaviour {

    private int NextBlock;
    public GameObject patternBlock1;
    public GameObject patternBlock2;
    public GameObject patternBlock3;

    public GameObject coinHautGauche;
    public GameObject coinBasDroite;

    private float longueur;
    private float colonne;
    private float reste;

    private float temp;


    
    


    // Use this for initialization
    void Start ()
    {
        Debug.Log("3");
        Debug.Log("2");
        Debug.Log("1");
        Debug.Log("GO!");

        longueur= Mathf.Abs(coinHautGauche.transform.position.x) + Mathf.Abs(coinHautGauche.transform.position.x);
        colonne = longueur / 1;
        reste = colonne;
        Mathf.Floor(colonne );
        reste = colonne - reste;


        //StartCoroutine(SpawnBlockParSeconde());

    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    IEnumerator SpawnBlockParSeconde ()
    {
        NewBlock(5f,0);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(SpawnBlockParSeconde() );
    }



    public void NewBlock (float zPosition,int numberOfTheLine)
    {
        

        NextBlock = Random.Range(1, 4);



        temp = Random.Range( (coinHautGauche.transform.position.x) , (coinBasDroite.transform.position.x) );
        Mathf.Floor(temp);

        if (temp <0 )
        {
            temp = temp - 0.5f;
        }
        else if (temp>=0)
        {
            temp = temp + 0.5f;
        }
        
        

        if (NextBlock == 1)
        {
            GameObject CurrentCube = Instantiate( patternBlock1, new Vector3( temp, 0.5f, zPosition), Quaternion.identity); //(x,y,z) (x=gauche/droite) (y=avant/arrière) (z=Haut/bas)
            CurrentCube.GetComponent<BlockGO>().SetNumber(numberOfTheLine );

            //TableauUltimeDesPosition =
        }
        else if (NextBlock == 2)
        {
            Instantiate(patternBlock2, new Vector3(temp, 0.5f, zPosition), Quaternion.identity);
        }
        else if (NextBlock == 3)
        {
            Instantiate(patternBlock3, new Vector3(temp, 0.5f, zPosition), Quaternion.identity);
        }
    }

}
