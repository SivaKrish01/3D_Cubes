using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public Vector3 vector;


    void Update()
    {
        transform.position = target.position + vector;
    }
}
