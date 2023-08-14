using UnityEngine.SceneManagement;
using UnityEngine;

public class Starting : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene(). buildIndex + 1);
    }
}
