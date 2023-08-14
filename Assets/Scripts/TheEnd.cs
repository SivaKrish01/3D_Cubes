using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    void OnTriggerEnter ()
    {
        FindObjectOfType<GameManager>().LevelComplete();
    }
}
