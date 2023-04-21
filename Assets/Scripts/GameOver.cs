using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text gameOverDisplay;
    void Start() {
        gameOverDisplay.gameObject.SetActive(false);
    }

    public void DisplayGameOver(string loser)
    {
        gameOverDisplay.text = "Game Over \n" + loser + " Lose";
        gameOverDisplay.gameObject.SetActive(true);
    }
}
