using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When right/left key is pressed...
        bool pressedJumpButton1 = Input.GetButtonDown("RightKey");
        bool pressedJumpButton2 = Input.GetButtonDown("LeftKey");

        //background goes down on the y axis by -1
        if (pressedJumpButton1 || pressedJumpButton2)
        {
            transform.Translate(0,-1,0);
        }
    }
}
