
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public Playermovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.tag);
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
        }

        
    }
}
