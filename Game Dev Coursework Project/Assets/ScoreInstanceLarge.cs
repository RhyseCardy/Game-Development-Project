using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class ScoreInstanceLarge : MonoBehaviour
{
    public AudioSource playSound;

    void OnTriggerEnter()
    {
    
    playSound.Play();
    Destroy(gameObject);
    Score.instance.AddPointLarge();

    }
}
