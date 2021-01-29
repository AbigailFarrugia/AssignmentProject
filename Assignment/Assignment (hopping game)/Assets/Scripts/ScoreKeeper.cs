using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField]

    //Adds Score field in Unity 
    public Text Score;

    //Adds menuScore field in Unity
    public Text menuScore;
    private int _currentScore = 0;

        void Start() 
    {
        //recalls last _currentScore stored
        menuScore.text = PlayerPrefs.GetInt("MenuScore", 0).ToString();
    }
    
    public void IncrementScore()
    {
        //takeing the _currentScore + 1
        Score.text = "Score: " + _currentScore.ToString();
        _currentScore++;

        //Storing _currentScore
        PlayerPrefs.SetInt("MenuScore", _currentScore);
    }
}