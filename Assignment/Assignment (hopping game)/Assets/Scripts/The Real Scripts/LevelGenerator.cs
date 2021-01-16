using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;
    public int numberOfPlatforms = 200;
    public int numberOfLevels = 200;

    public float platformSpacerX = 0f;
    public float platformSpacerY = 0f;
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
                spawnPosition1.x += platformSpacerX;
                Instantiate(platformPrefab, spawnPosition1, Quaternion.identity);
            }
            for (int l = 0; l < numberOfPlatforms; l++)
            {
                spawnPosition1.x -= platformSpacerX;
            }

            spawnPosition1.y += platformSpacerY;
            Instantiate(platformPrefab, spawnPosition1, Quaternion.identity);
        }


        for (int i = 0; i < numberOfLevels; i++)
        {
            for (int j = 0; j < numberOfPlatforms; j++)
            {
                spawnPosition2.x += platformSpacerX;
                Instantiate(platformPrefab, spawnPosition2, Quaternion.identity);
            }
            for (int l = 0; l < numberOfPlatforms; l++)
            {
                spawnPosition2.x -= platformSpacerX;
            }

            spawnPosition2.y += platformSpacerY;
            Instantiate(platformPrefab, spawnPosition2, Quaternion.identity);
        }

    }
}

