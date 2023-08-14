using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform ts;
    public Text scoreText;

    void Update()
    {
        scoreText.text = ts.position.z.ToString("0");   
    }
}
