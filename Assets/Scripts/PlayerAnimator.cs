using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] Animator animator;

    public void PlayFront()
    {
        animator.Play("CH_Front");
    }

    public void PlayLeft()
    {
        animator.Play("CH_Left");
    }

    public void PlayRight()
    {
        animator.Play("CH_Right");
    }
}