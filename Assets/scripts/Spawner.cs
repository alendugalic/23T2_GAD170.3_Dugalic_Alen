using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform Spawnpoint;
    public Rigidbody objectToSpawn;
   
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Rigidbody Bolder;
        Bolder = Instantiate(objectToSpawn, Spawnpoint.position, Spawnpoint.rotation) as Rigidbody;
    }
    void Update()
    {
      
    }
    

}
