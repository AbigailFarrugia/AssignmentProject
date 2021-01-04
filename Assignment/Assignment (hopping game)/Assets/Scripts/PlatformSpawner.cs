using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] platforms;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, platforms.Length);
        Instantiate(platforms[rand], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
