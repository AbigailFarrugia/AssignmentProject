using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    private bool isOnPlatform;
    private GameObject[] CrackedPlat;
    public Vector2 spawnPositionTest;
    public LayerMask FrogLayer;
    public GameObject BrokenPlatformPrefab;
    public float timeOfPlatformBreaking = 1f;
    public Transform landedCheck;
//https://forum.unity.com/threads/how-to-get-a-trigger-to-identify-a-prefab-clone.199053/
    // Start is called before the first frame update
    void Start()
    {
        CrackedPlat = new GameObject[20];

        CrackedPlat[0] = (GameObject)Instantiate(BrokenPlatformPrefab, spawnPositionTest, Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isOnPlatform = Physics2D.OverlapCircle(landedCheck.position, 1f, FrogLayer);

        if (isOnPlatform)
        {
            timeOfPlatformBreaking -= Time.deltaTime;
            if (timeOfPlatformBreaking < 0)
            {
                CrackedPlat[0].SetActive(false);
            }

        }
    }

    void BreakOnLand()
    {
        isOnPlatform = Physics2D.OverlapCircle(landedCheck.position, 1f, FrogLayer);

        if (isOnPlatform)
        {
            timeOfPlatformBreaking -= Time.deltaTime;
            if (timeOfPlatformBreaking < 0)
            {
                CrackedPlat[0].SetActive(false);
            }

        }

    }

}
