using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class ScoreInstanceSmall : MonoBehaviour
{

    void OnTriggerEnter()
    {
        
    Destroy(gameObject);
    Score.instance.AddPointSmall();

    }
}
