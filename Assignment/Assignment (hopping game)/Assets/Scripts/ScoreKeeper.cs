using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField]
    private int currentScore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncrementScore()
    {
        //takeing the _currentscore + 1

        Text ScoreText = GetComponent<Text>();
        ScoreText.text = "Score: " + currentScore.ToString();
        currentScore++;
    }
}
