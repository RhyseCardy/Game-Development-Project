using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class ScoreInstanceMedium : MonoBehaviour
{

    void OnTriggerEnter()
    {
        
    Destroy(gameObject);
    Score.instance.AddPointMedium();

    }
}
