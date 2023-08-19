using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireSpawn : MonoBehaviour
{
    public Transform spawnPoint;
    public Rigidbody objectToSpawn;
    public bool objectSpawned = false;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        if (objectSpawned == false)
        {
            Rigidbody fire;
            fire = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
            objectSpawned = true;
            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
