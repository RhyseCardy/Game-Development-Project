using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;

    void onTriggerEnter(Collider collider)
    {
         if(collider.tag == "Block Trigger"){
            Debug.Log("Collison");
            Instantiate(Prefab, Spawnpoint);
         }
    }
}
