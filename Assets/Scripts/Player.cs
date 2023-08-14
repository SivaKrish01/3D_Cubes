using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 2000;
    public float sidewaysforce = 500f;

    void Update()
    {
        rb.AddForce(0,0,force*Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        
    }
}
