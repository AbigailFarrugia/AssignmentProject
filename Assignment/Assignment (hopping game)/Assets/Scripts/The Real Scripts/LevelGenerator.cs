using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;
    public int numberOfPlatforms = 200;
     public int numberOfLevels = 200;
    public Vector3 spawnPosition1;
    public Vector3 spawnPosition2;  
    // Use this for initialization
    void Start()
    {

        //Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numberOfLevels; i++)
        {
            for (int j = 0; j < numberOfPlatforms; j++)
            {
                spawnPosition1.x += 5f;
                Instantiate(platformPrefab, spawnPosition1, Quaternion.identity);
            }
            for (int l = 0; l < numberOfPlatforms; l++)
            {
                spawnPosition1.x -= 5f;
            }

            spawnPosition1.y += 5f;
            Instantiate(platformPrefab, spawnPosition1, Quaternion.identity);
        }


        for (int i = 0; i < numberOfLevels; i++)
        {
            for (int j = 0; j < numberOfPlatforms; j++)
            {
                spawnPosition2.x += 5f;
                Instantiate(platformPrefab, spawnPosition2, Quaternion.identity);
            }
            for (int l = 0; l < numberOfPlatforms; l++)
            {
                spawnPosition2.x -= 5f;
            }

            spawnPosition2.y += 5f;
            Instantiate(platformPrefab, spawnPosition2, Quaternion.identity);
        }

    }
}

