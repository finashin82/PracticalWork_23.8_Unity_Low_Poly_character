using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationPanel : MonoBehaviour
{
    [SerializeField] private Text textAnimation;

    // Start is called before the first frame update
    void Start()
    {
        textAnimation.text = "1 - MMA Kick\n<b>2 - Stabbing</b>\n3 - Lift\n4 - Sword\n5 - Uppercut\n\n0 - Idle";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
