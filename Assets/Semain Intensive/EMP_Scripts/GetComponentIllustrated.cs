using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentIllustrated : MonoBehaviour 
{

    public List<AudioClip> soundsList;
    AudioClip clip;
    AudioSource source;

	// Use this for initialization
	void Start () 
    {
        clip = this.GetComponent<AudioSource>().clip;
        source = this.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            float randomEdgeSize = Random.Range(1f, 2f);
            Vector2 boxColliderSize = this.GetComponent<BoxCollider2D>().size;
            boxColliderSize = new Vector2(randomEdgeSize,randomEdgeSize);
            this.GetComponent<BoxCollider2D>().size = boxColliderSize;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            if (source.isPlaying)
            {
                source.Stop();
            }
            int iRandomTrack = Random.Range(0, soundsList.Count);
            clip = soundsList[iRandomTrack];
            source.clip = clip;
            source.Play();
        }

	}
}
