using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public Rigidbody objectToSpawn;
    public bool objectSpawned = false;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        if (objectSpawned == false)
        {
            Rigidbody bolder;
            bolder = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            objectSpawned = true;
            bolder.velocity = new Vector3(0f, -10f, 0f);
        }
        
    }
    void Update()
    {
       
    }
    
    
}
