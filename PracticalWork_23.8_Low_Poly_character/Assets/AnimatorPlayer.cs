using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPlayer : MonoBehaviour
{
    private Animator animatorPlayer;

    private void Awake()
    {
        animatorPlayer = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isMmaKick", true);
        }
        
        if (Input.GetKeyDown("2"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isStabbing", true);
        }

        if (Input.GetKeyDown("3"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isLift", true);
        }

        if (Input.GetKeyDown("4"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isSword", true);
        }

        if (Input.GetKeyDown("5"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isUppercut", true);
        }

        if (Input.GetKeyDown("0"))
        {
            ResetAllAnimations();            
        }
    }

    /// <summary>
    /// Сброс всех анимаций и возвращение в исходное положение Idle
    /// </summary>
    private void ResetAllAnimations()
    {
        animatorPlayer.SetBool("isMmaKick", false);
        animatorPlayer.SetBool("isStabbing", false);
        animatorPlayer.SetBool("isLift", false);
        animatorPlayer.SetBool("isSword", false);
        animatorPlayer.SetBool("isUppercut", false);
    }
}
