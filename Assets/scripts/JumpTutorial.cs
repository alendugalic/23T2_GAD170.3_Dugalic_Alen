using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpTutorial : MonoBehaviour
{
    [SerializeField] private TextMeshPro tutorialText;
    private bool spaceBeenPressed = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spaceBeenPressed = true;
            return;
        }
        if (spaceBeenPressed)
        {
            if (tutorialText.enabled == true)
            {
                tutorialText.enabled = false;
                Debug.Log("Space Pressed");
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

            // Debug.Log("Jump done");
            tutorialText.enabled = true;
        }
    }
}