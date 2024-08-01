using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimatorPlayer : MonoBehaviour
{
    private Animator animatorPlayer;

    [SerializeField] private UnityEvent<AnimatorPlayer> eventAnimation;

    private int selectedAnimation;

    public int SelectedAnimation => selectedAnimation;   

    private void Awake()
    {
        animatorPlayer = GetComponent<Animator>();
    }

    void Update()
    {       
        InputKey();
    }

    /// <summary>
    /// Проверка нажатия клавиш
    /// </summary>
    public void InputKey()
    {
        if (Input.GetKeyDown("1"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isMmaKick", true);

            selectedAnimation = 1;
        }

        if (Input.GetKeyDown("2"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isStabbing", true);

            selectedAnimation = 2;
        }

        if (Input.GetKeyDown("3"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isLift", true);

            selectedAnimation = 3;
        }

        if (Input.GetKeyDown("4"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isSword", true);

            selectedAnimation = 4;
        }

        if (Input.GetKeyDown("5"))
        {
            ResetAllAnimations();
            animatorPlayer.SetBool("isUppercut", true);

            selectedAnimation = 5;
        }

        if (Input.GetKeyDown("0"))
        {
            ResetAllAnimations();

            selectedAnimation = 0;
        }

        eventAnimation?.Invoke(this);
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
