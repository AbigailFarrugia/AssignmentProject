using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //The jump's force
    [SerializeField]
    private float _force = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        //When spacebar is clicked the character will jump on the first platform and the game starts
        
    }

    // Update is called once per frame
    void Update()
    {
        //If right or left arrow is pressed player should jump
        bool pressedJumpButton1 = Input.GetButtonDown("RightKey");
        bool pressedJumpButton2 = Input.GetButtonDown("LeftKey");

        //If rightkey is pressed pressedJumpButton = True
        if(pressedJumpButton1 || pressedJumpButton2)
        {
            //storing the rigidbody2D component into the variable rigidbody
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            //setting rigidbody to zero Vector3(x,y,z)
            rigidbody.velocity = Vector3.zero;
            //adding jumping force to rigidbody Vector3(0,1,0) * force(1000f)
            rigidbody.AddForce(Vector3.up * _force);
        }
    }
}
