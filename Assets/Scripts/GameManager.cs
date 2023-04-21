using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isEnd { get; private set; }
    public bool isStart { get; private set; }

    void Start() 
    {
        isEnd = false;
        isStart = false;
        Time.timeScale = 1;
    }

    void Update()
    {
        // restart the game when the spacebar is pressed
        if (isEnd && Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void StartGame() 
    {
        isStart = true;
    }

    public void EndGame(string loser)
    {
        // display game over UI
        FindObjectOfType<GameOver>().DisplayGameOver(loser);
        isEnd = true;
        isStart = false;
        Time.timeScale = 0;
    }
}
