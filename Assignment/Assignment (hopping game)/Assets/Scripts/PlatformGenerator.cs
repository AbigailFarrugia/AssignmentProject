using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;
    public GameObject[] thePlatforms;
    private float platformHeight;
    private int platformSelector;

    // Start is called before the first frame update
    void Start()
    {
        platformHeight = thePlatform.GetComponent<BoxCollider2D>().size.y;
        int rand = Random.Range(0, thePlatforms.Length);
        Instantiate(thePlatforms[rand], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < generationPoint.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + platformHeight + distanceBetween, transform.position.z);
            platformSelector = Random.Range(0, thePlatforms.Length);
            Instantiate (thePlatforms[platformSelector], transform.position, transform.rotation);
        }
    }
}
