using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using Unity.VisualScripting;

public class MovementTutorial : MonoBehaviour


{
    [SerializeField] private TextMeshPro tutorialText;
    //Need to add 3 Bulians to check for the presses 
    private bool wBeenPressed = false;
    private bool aBeenPressed = false;
    private bool dBeenPressed = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            wBeenPressed = true;
            return;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            aBeenPressed = true;
            return;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            dBeenPressed = true;
            return;
        }
        // This checks that if the AWD have been pressed to end the loop :)
        if (wBeenPressed && aBeenPressed && dBeenPressed)
        {
            if (tutorialText.enabled == true)
            {
                tutorialText.enabled = false;
                Debug.Log("work");
            } 

        }
            

        

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) 
        {
            return;
        }
        {

           // Debug.Log("movement done");
            tutorialText.enabled = true;
        }
    }
}
