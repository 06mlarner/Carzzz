using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SpawnIce : MonoBehaviour
{
  public Transform spawnPoint;
  public GameObject prefab;

  void OnTriggerEnter(Collider other) {
    
    Debug.Log("trigger entered");
    
    Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    
    Debug.Log("object spawned");
  }
}
