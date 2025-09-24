using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorBoxController : MonoBehaviour
{
    private Animator animator;
    public AnimatorBoxController myAnimatorController;

    void Start()
    {

        animator = GetComponent<Animator>();

        // animator.runtimeAnimatorController = myAnimatorController;
    }

    public void SetAnimationState(bool inCol)
    {
        animator.SetBool("inCol", inCol);

        if (inCol)
        {
            animator.speed = 1.0f;
        }
        else
        {
            animator.speed = -1.0f;
        }
    }
}
