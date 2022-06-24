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
        GetComponent<Renderer>().material.color = Color.white;
        Vector3 scale = transform.localScale;
        scale.y = 0.1f;
        transform.localScale = scale;
    }

    void notAlive()
    {
        GetComponent<Renderer>().material.color = Color.white;
        Vector3 scale = transform.localScale;
        scale.y = 1.5f;
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
