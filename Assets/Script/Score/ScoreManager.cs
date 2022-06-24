using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public List<PlayerController> listPlayer;

    public GameObject gameOver;
    public Text gameOverText;
    
    public void RegisterPlayer(PlayerController player)
    {
        listPlayer.Add(player);
    }
    public void RemovePlayer(PlayerController player)
    {
        listPlayer.Remove(player);
        if (listPlayer.Count == 1)
        {
            GameOver(listPlayer[0]);
        }
    }
    public void GameOver(PlayerController winner)
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
        gameOverText.text = winner.name + " wins!";

    }
}
