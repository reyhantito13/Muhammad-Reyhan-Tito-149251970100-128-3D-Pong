using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public List<BallSpawner> ballSpawners;
    public int maxBall;

    public float spawnInterval;

    private List<BallController> ballList;

    void Start()
    {
        ballList = new List<BallController>();
        InvokeRepeating("SpawnBall", spawnInterval, spawnInterval);
    }

    void SpawnBall()
    {
        if (ballList.Count >= maxBall)
        {
            return;
        }
        BallSpawner ballSpawner = ballSpawners[Random.Range(0, ballSpawners.Count)];
        BallController ball = ballSpawner.Spawn();
        ballList.Add(ball);
    }

    public void RemoveBall(BallController ball)
    {
        ballList.Remove(ball);
        Destroy(ball.gameObject);
    }
}
