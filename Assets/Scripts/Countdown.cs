using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public int countTime = 3;
    public Text countdownDisplay;

    void Start() {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart() 
    {
        // count down method
        while(countTime > 0)
        {
            countdownDisplay.text = countTime.ToString();
            yield return new WaitForSeconds(1f);
            countTime--;
        }

        countdownDisplay.text = "Fight";
        yield return new WaitForSeconds(1f);

        // start the game
        FindObjectOfType<GameManager>().StartGame();

        countdownDisplay.gameObject.SetActive(false);
    }
}
