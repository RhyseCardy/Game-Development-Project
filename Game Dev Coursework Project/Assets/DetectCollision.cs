using UnityEngine;

public class DetectCollision : MonoBehaviour
{

   void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Finish")
        {
            Debug.Log("Finish Hit");
        }
    }   

}
