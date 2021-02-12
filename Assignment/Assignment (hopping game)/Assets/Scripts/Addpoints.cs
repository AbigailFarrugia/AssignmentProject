using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addpoints : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        //checking if there's a collision with player
        if(other.tag == "Player")
        {
            //a reference to the scorekeeper script
            ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();

            //checking if script was found
            if(scoreKeeper != null)
            {
                //incrimentScore
                scoreKeeper.IncrementScore();
            }
            //unallowing score to double if player lands on the same platform twice
            Destroy(this.gameObject);
        }
    }
}
