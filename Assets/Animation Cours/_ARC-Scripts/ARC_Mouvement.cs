using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARC_Mouvement : MonoBehaviour
{

    Animator anim;
    int walkTreeHash = Animator.StringToHash("Base Layer.Walk Tree");
    int runTreeHash = Animator.StringToHash("Base Layer.Run Tree");

    public float speed = 0.35f;

    // Use this for initialization  
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo animStateInfo = anim.GetCurrentAnimatorStateInfo(0);

        float velocity = Input.GetAxis("Vertical");
        float velocityX = Input.GetAxis("Horizontal");

        anim.SetFloat("Velocity", velocity);
        anim.SetFloat("VelocityX", velocityX);

        if (Input.GetKeyDown(KeyCode.Space) && ((animStateInfo.fullPathHash == walkTreeHash) || (animStateInfo.fullPathHash == runTreeHash)))
        {
            anim.SetTrigger("Roll");
        }
        else
        {
            Move(velocityX*speed, velocity*speed);
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                anim.SetTrigger("Grenade");
            }

        }


    }


    private void Move(float x, float z)
    {
        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);
    }

}