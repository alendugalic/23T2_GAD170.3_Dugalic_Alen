using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIScript : MonoBehaviour
{
    public TMP_Text timerText;
    public TMP_Text deathCounterText;
    public TMP_Text buttonPressCounterText;

    private float gameTimer;
    private int deathCounter;
    private int buttonPressCounter;

    private void Start()
    {
        gameTimer = 0f;
        deathCounter = 0;
        buttonPressCounter = 0;
       UpdateDeathCounterUI();
    }

    private void Update()
    {
        // Update the game timer
        gameTimer += Time.deltaTime;
        timerText.text = "Timer: " + Mathf.Round(gameTimer).ToString();

        // Update the death counter (increment this counter when the player dies)

        deathCounterText.text = "Deaths: " + deathCounter.ToString();

        // Update the button press counter (increment this counter when the 'E' key is pressed)
        if (Input.GetKeyDown(KeyCode.E))
        {
            buttonPressCounter++;
        }
        buttonPressCounterText.text = "Button Presses: " + buttonPressCounter.ToString();
    }

    // Call this function to increment the death counter
    private void UpdateDeathCounterUI()
    {
        deathCounterText.text = "Deaths: " + deathCounter.ToString();
    }

}
