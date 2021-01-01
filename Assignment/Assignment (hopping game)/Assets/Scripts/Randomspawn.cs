using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomspawn : MonoBehaviour {
public GameObject Theplatform;
public float placeX;
public float placeY;

    void Start()
 {
placeX = Random.Range(-9,-5);
placeY = Random.Range(-17,105);
Theplatform.transform.position = new Vector3(placeX,placeY,5);
 }

}
