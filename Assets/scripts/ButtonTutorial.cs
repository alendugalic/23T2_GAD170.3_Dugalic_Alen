using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonTutorial : MonoBehaviour
{
    [SerializeField] private TextMeshPro tutorialText;
    private bool EBeenPressed = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            EBeenPressed = true;
            return;
        }
        if (EBeenPressed)
        {
            if (tutorialText.enabled == true)
            {
                tutorialText.enabled = false;
                Debug.Log("E Pressed");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            return;
        }
        {

            Debug.Log("Press done");
            tutorialText.enabled = true;
        }
    }
}