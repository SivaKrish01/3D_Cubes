using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    public Player movement;

    void OnCollisionEnter (Collision Collisioninfo)
    {
        if(Collisioninfo.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }


}
