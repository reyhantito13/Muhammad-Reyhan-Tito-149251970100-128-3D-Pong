using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public BallController ballTemplate;
  
    public BallController Spawn(){
        BallController ball = Instantiate(ballTemplate, ballTemplate.transform.position, Quaternion.identity);
        ball.gameObject.SetActive(true);
        return ball;
    }
}
