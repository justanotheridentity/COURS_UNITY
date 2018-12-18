using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncSpawn : MonoBehaviour
{
    public GameObject gameManager;

    public void OnTriggerEnter(Collider other)
    {
        
       //  gameManager.GetComponent<Block_Manager>().NewBlock(other.gameObject.transform.position.z);
            

    }

}