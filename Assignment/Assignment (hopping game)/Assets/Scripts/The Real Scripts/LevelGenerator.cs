using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    //Our Variables
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject GrassPlatformPrefab;
    public GameObject BreakableGrassPlatformPrefab;
    public GameObject StonePlatformPrefab;
    public GameObject CloudPlatformPrefab;
    public GameObject GhostPlatformPrefab;
    public int numberOfPlatforms = 200;
    public int numberOfLevels = 200;
    public float platformSpacerX = 0f;
    public float platformSpacerY = 0f;
    public Vector2 spawnPosition1;
    public Vector2 spawnPosition2;
    int prefabIndex;

    void Start()
    {
        prefabList.Add(StonePlatformPrefab);
        prefabList.Add(GrassPlatformPrefab);
        prefabList.Add(BreakableGrassPlatformPrefab);
        prefabList.Add(CloudPlatformPrefab);
        prefabList.Add(GhostPlatformPrefab);
        prefabIndex = UnityEngine.Random.Range(0, 5);

        // loop for the amount of levels
        for (int i = 0; i < numberOfLevels; i++)
        {
            //loop for the amount of platforms 
            for (int j = 0; j < numberOfPlatforms; j++)
            {
                if (i < 5)
                {
                    prefabIndex = UnityEngine.Random.Range(0, i);
                }
                else
                {
                    prefabIndex = UnityEngine.Random.Range(0, 5);
                }

                //create new platform at givent coordinate
                Instantiate(prefabList[prefabIndex], spawnPosition1, Quaternion.identity);
                //to create new platform near previous platform 
                spawnPosition1.x = spawnPosition1.x + platformSpacerX;

            }
            for (int l = 0; l < numberOfPlatforms; l++)
            {
                //to reverse platform spawnpoint 
                spawnPosition1.x = spawnPosition1.x - platformSpacerX;
            }
            //to move spawn point up in y axis
            spawnPosition1.y += platformSpacerY;
        }


        for (int i = 0; i < numberOfLevels; i++)
        {
            for (int j = 0; j < numberOfPlatforms; j++)
            {
                if (i < 5)
                {
                    prefabIndex = UnityEngine.Random.Range(0, i);
                }
                else
                {
                    prefabIndex = UnityEngine.Random.Range(0, 5);
                }
                spawnPosition2.x = spawnPosition2.x + platformSpacerX;
                Instantiate(prefabList[prefabIndex], spawnPosition2, Quaternion.identity);
            }
            for (int l = 0; l < numberOfPlatforms; l++)
            {
                spawnPosition2.x = spawnPosition2.x - platformSpacerX;
            }

            spawnPosition2.y = spawnPosition2.y + platformSpacerY;
        }

    }
}

