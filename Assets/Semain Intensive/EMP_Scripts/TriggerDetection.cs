using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TriggerDetection : MonoBehaviour
{

    public CinemachineVirtualCamera cameraGame;
    public float fieldOfViewForPanelEnter = 2.12f;
    public float fieldOfViewForPanelExit = 5.35f;

    public bool bUpdatePanelEnter = false;
    public bool bUpdatePanelExit = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
     
        if(bUpdatePanelEnter)
        {

            StartCoroutine(UpdateCameraSize(-0.1f));
            if (cameraGame.m_Lens.OrthographicSize <= fieldOfViewForPanelEnter)
            {
                cameraGame.m_Lens.OrthographicSize = fieldOfViewForPanelEnter;
                bUpdatePanelEnter = false;
                StopCoroutine("UpdateCameraSize");
            }
            else
            {
                cameraGame.m_Lens.OrthographicSize -= 0.1f;
            }
        }
        if(bUpdatePanelExit)
        {
            StartCoroutine(UpdateCameraSize(0.1f));
            if (cameraGame.m_Lens.OrthographicSize >= fieldOfViewForPanelExit)
            {
                cameraGame.m_Lens.OrthographicSize = fieldOfViewForPanelExit;
                bUpdatePanelExit = false;
                StopCoroutine("UpdateCameraSize");
            }
            else
            {
                cameraGame.m_Lens.OrthographicSize += 0.1f;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "PennyPixel")
        {
            bUpdatePanelEnter = true;
            if (bUpdatePanelExit)
            {
                bUpdatePanelExit = false;
            }
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "PennyPixel")
        {
            bUpdatePanelExit = true;
            if (bUpdatePanelEnter)
            {
                bUpdatePanelEnter = false;
            }
        }
    }

    private IEnumerator UpdateCameraSize(float deltaTime)
    {
        yield return new WaitForSeconds(deltaTime);
        //cameraGame.m_Lens.OrthographicSize += deltaTime;
    }
}
