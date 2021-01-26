﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPlatformScript : MonoBehaviour
{

    public GameObject BrokenPlatformPrefab;
    private float time;

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

        time = Mathf.PingPong(Time.time, 2);

        if (time < 1f)
        {
            BrokenPlatformPrefab.GetComponent<Renderer>().enabled = false;
            BrokenPlatformPrefab.GetComponent<Collider2D>().enabled = false;
        }
        else if (time > 1f)
        {
            BrokenPlatformPrefab.GetComponent<Renderer>().enabled = true;
            BrokenPlatformPrefab.GetComponent<Collider2D>().enabled = true;
        }
    }

}
