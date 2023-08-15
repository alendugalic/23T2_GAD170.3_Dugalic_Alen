using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;
using static UnityEngine.Rendering.DebugUI.Table;

public class ImpactTester : MonoBehaviour
{
    // we want this script to handle collisions and trigger detection
    //when our object impacts another we want to print text
    //onTrigger is used when collision doesnt need to stop
    //onCollisionEnter stops when it makes contact
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("AUCH! ");

        //destroy the objects its attatched to if its Destroy(gameObject) but if its (collision.gameObject) it destroys what it touches.
        //Destroy(collision.gameObject);

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("i have been triggered! ");


        //restart the scene (use for your trap resets)
        //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

