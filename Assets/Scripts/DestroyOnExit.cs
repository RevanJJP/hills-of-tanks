using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Source: https://answers.unity.com/questions/670860/delete-object-after-animation-2d.html
public class DestroyOnExit : StateMachineBehaviour {
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        Destroy(animator.gameObject, stateInfo.length);
    }
}