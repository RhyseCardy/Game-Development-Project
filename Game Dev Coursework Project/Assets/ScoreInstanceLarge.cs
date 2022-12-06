using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class ScoreInstanceLarge : MonoBehaviour
{

    void OnTriggerEnter()
    {
        
    Destroy(gameObject);
    Score.instance.AddPointLarge();

    }
}
