using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMotionController : StateMachineBehaviour
{
    // This will be called when the animation starts (OnStateEnter)
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Enable root motion when entering this animation state
        animator.applyRootMotion = true;
    }

    // This will be called when the animation finishes (OnStateExit)
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Disable root motion when exiting this animation state
        animator.applyRootMotion = false;
    }
}