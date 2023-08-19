using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTrigger : MonoBehaviour
{
    public GameObject[] fireworkPrefabs;
    public AudioClip[] fireworkSounds;
    public string endGameSceneName;

    [SerializeField]
    private Transform spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4;

    private bool endGameTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !endGameTriggered)
        {
            endGameTriggered = true;

            Transform[] spawnPoints = { spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4 };

            for (int i = 0; i < fireworkPrefabs.Length; i++)
            {
                if (i < spawnPoints.Length && spawnPoints[i] != null)
                {
                    Vector3 spawnPosition = spawnPoints[i].position;

                    GameObject firework = Instantiate(fireworkPrefabs[i], spawnPosition, Quaternion.identity);
                    AudioSource audioSource = firework.GetComponent<AudioSource>();

                    if (audioSource && i < fireworkSounds.Length)
                    {
                        audioSource.clip = fireworkSounds[i];
                        audioSource.Play();
                    }
                }
            }

            SceneManager.LoadScene(endGameSceneName);
        }
    }
}

