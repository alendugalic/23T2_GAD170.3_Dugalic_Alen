using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretButton : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.E;

    private void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            GameObject[] doors = GameObject.FindGameObjectsWithTag("door");
            foreach (GameObject door in doors)
            {
                Destroy(door);
            }
        }
    }
}

    

