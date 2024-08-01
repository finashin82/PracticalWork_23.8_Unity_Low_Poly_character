using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class AnimationPanel : MonoBehaviour
{
    [SerializeField] private Text textAnimation;

    private int select;

    private void Awake()
    {
        select = 0;
    }

    void Update()
    {       
        switch (select)
        {
            case 1:
                textAnimation.text = "<b>1 - MMA Kick</b>\n2 - Stabbing\n3 - Lift\n4 - Sword\n5 - Uppercut\n\n0 - Idle";
                break;
            case 2:
                textAnimation.text = "1 - MMA Kick\n<b>2 - Stabbing</b>\n3 - Lift\n4 - Sword\n5 - Uppercut\n\n0 - Idle";
                break;
            case 3:
                textAnimation.text = "1 - MMA Kick\n2 - Stabbing\n<b>3 - Lift</b>\n4 - Sword\n5 - Uppercut\n\n0 - Idle";
                break;
            case 4:
                textAnimation.text = "1 - MMA Kick\n2 - Stabbing\n3 - Lift\n<b>4 - Sword</b>\n5 - Uppercut\n\n0 - Idle";
                break;
            case 5:
                textAnimation.text = "1 - MMA Kick\n2 - Stabbing\n3 - Lift\n4 - Sword\n<b>5 - Uppercut</b>\n\n0 - Idle";
                break;
            default:
                textAnimation.text = "1 - MMA Kick\n2 - Stabbing\n3 - Lift\n4 - Sword\n5 - Uppercut\n\n<b>0 - Idle</b>";
                break;
        }
    }

    public void TextAnim(AnimatorPlayer AnimPlayer)
    {        
        select = AnimPlayer.SelectedAnimation;        
    }
}
