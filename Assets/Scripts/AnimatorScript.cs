using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
     animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            // animator.SetBool("forward", true);
            animator.SetTrigger("forward");
        }
    }
}
