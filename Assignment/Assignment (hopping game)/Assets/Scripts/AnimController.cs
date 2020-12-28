using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool pressedJumpButton1 = Input.GetButtonDown("RightKey");
        bool pressedJumpButton2 = Input.GetButtonDown("LeftKey");

        if (pressedJumpButton1 || pressedJumpButton2)
        {
            anim.Play("JumpAnimation");
        }
    }
}
