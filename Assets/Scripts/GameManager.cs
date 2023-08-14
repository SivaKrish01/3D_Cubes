using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  
    public GameObject CompleteLevel;
    bool gameended = false;
    public float Restartdelay = 1f;

    public void LevelComplete()
    {
      CompleteLevel.SetActive(true);
    }

    public void EndGame()
    {
      if(gameended == false)
      {
        gameended = true;
        Debug.Log("GameOver");
        Invoke("restart", Restartdelay);
      }
    }

    void restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
