using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSpaceHarrierFloor : MonoBehaviour 
{

    public Material FloorMaterial;
    public float scrollSpeed = 0.5f;
    float offset;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        offset += (Time.deltaTime * scrollSpeed) / 10.0f;
        FloorMaterial.SetTextureOffset("_MainTex", new Vector2(0,offset*-1));	
	}
}
