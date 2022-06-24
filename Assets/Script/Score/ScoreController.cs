using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text playerName;
    public Text playerScore;    
    private int score;

    public ScoreManager manager;
    private PlayerController listPlayer;

    public void Init(PlayerController player, string playerName)
    {
        this.playerName.text = playerName;
        listPlayer = player;
        manager.RegisterPlayer(player);
    }
    public void addScore()
    {
        score++;
        playerScore = transform.Find("Score").GetComponent<Text>();
        playerScore.text = score.ToString();
        if (maxScore())
        {
            manager.RemovePlayer(listPlayer);
        }
    }
    public bool maxScore()
    {
        return score >= 15;
    }
}
