using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource playSound;

    void OnTriggerEnter()
    {
        playSound.Play();
        gameManager.CompleteLevel();
    }
}
