using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerRespawn : MonoBehaviour
{
    private CharacterController controller;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            controller = other.GetComponent<CharacterController>();
            if (controller != null)
            {
                controller.enabled = false;
            }
            Vector3 teleportPosition = new Vector3 (37.6f, 7.97f, -27.12f);
            other.transform.position = teleportPosition;
            controller.enabled = true;
        }
    }
   
}

