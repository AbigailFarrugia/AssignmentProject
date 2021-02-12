using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    public float wait_time = 5f;
    void Start()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        //Telling unity to wait for 5 seconds(animation time)
        yield return new WaitForSeconds(wait_time);

        //Telling unity to load next scene after the time runs out
        SceneManager.LoadScene(+1);
    }
}
