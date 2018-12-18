using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollPropsElements : MonoBehaviour {

    public GameObject propToScroll;
    public Camera cameraForCheckingPosition;
    public float scrollSpeed = 0.5f;
    float offset;
    float initialPosZ;

    // Use this for initialization
    void Start()
    {
        initialPosZ = propToScroll.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10.0f;
        initialPosZ += offset * -1;
        propToScroll.transform.position = new Vector3(propToScroll.transform.position.x, propToScroll.transform.position.y, initialPosZ);

        if (propToScroll.transform.position.z < cameraForCheckingPosition.transform.position.z)
            Destroy(gameObject);
    }
}
