using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPlatformScript : MonoBehaviour
{

    public GameObject BrokenPlatformPrefab;
    private float time;
    public int disappearTime;
    public int appearTime;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Pulsate();

    }

    void Pulsate()
    {

        time = Mathf.PingPong(Time.time, disappearTime);

        if (time < disappearTime/2)
        {
            BrokenPlatformPrefab.GetComponent<Renderer>().enabled = false;
            BrokenPlatformPrefab.GetComponent<Collider2D>().enabled = false;
        }
        else if (time > appearTime/2)
        {
            BrokenPlatformPrefab.GetComponent<Renderer>().enabled = true;
            BrokenPlatformPrefab.GetComponent<Collider2D>().enabled = true;
        }
    }

}
