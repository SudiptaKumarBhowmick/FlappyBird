using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        Debug.Log("Add score called");
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
}
