using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackgroundTexture : MonoBehaviour {

    public Material materialToScroll;
    public float scrollSpeed = 3f;
    float offsetX;
    //public float offsetY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        offsetX += (Time.deltaTime * scrollSpeed) / 10.0f;
        materialToScroll.SetTextureOffset("_MainTex", new Vector2(offsetX, 0));
    }
}
