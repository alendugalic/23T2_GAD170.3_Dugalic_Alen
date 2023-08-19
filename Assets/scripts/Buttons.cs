using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject doorToDestroy;
    public KeyCode interactKey = KeyCode.E;
    public Color pressedColor = Color.yellow;

    private bool canInteract = false;
    private bool buttonPressed = false;
    private Renderer buttonRenderer;
    public AudioSource soundEffect;
    public UIScript uiScript;
    private void Start()
    {
        buttonRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !buttonPressed)
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && !buttonPressed)
        {
            canInteract= false;
        }
    }

    private void Update()
    {
        if (!buttonPressed && canInteract && Input.GetKeyDown(interactKey))
        {
            Destroy(doorToDestroy);
            buttonRenderer.material.color = pressedColor;
            buttonPressed = true;
            soundEffect.Play();
            
        }
    }
}
