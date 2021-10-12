using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            animator.SetBool("isForward", true);
        }
         if(Input.GetKey(KeyCode.S)) {
            animator.SetBool("isForward", false);
        }
        if(Input.GetKey(KeyCode.A)) {
            animator.SetBool("isBackward", true);
        }
        if(Input.GetKey(KeyCode.D)) {
            animator.SetBool("isBackward", false);

        }
    }
}
