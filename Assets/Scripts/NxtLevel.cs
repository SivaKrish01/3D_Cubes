using UnityEngine.SceneManagement;
using UnityEngine;

public class NxtLevel : MonoBehaviour
{
    public void LoadNxtLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene(). buildIndex + 1);
    }
}
