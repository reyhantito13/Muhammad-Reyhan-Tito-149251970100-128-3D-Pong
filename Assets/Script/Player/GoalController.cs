using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public GameObject paddle;
    public BallManager ballManager;
    public PlayerController player;

    void Update()
    {
        bool isAlive = !player.scoreController.maxScore();
        GetComponent<Collider>().isTrigger = isAlive;
        if (isAlive)
        {
            Alive();
        }
        else
        {
            notAlive();
        }      
    }

    void Alive()
    {
        Vector3 scale = transform.localScale;
        scale.y = 0;
        transform.localScale = scale;
    }

    void notAlive()
    {
        GetComponent<Renderer>().material.color = Color.red;
        Vector3 scale = transform.localScale;
        scale.y = 1;
        transform.localScale = scale;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<BallController>() != null && paddle.activeSelf)
        {
            ballManager.RemoveBall(collision.gameObject.GetComponent<BallController>());
            player.scoreController.addScore();
        }
    }
}
