using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroyer : MonoBehaviour {

    

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Block") // other =
       {
            Destroy (other.gameObject); 
       }
    }
}
