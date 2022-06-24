using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public Vector3 leftDirection;
    public Vector3 rightDirection;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public PlayerController player;

    private void Update()
    {
        bool isAlive = !player.scoreController.maxScore();
        
        if (isAlive)
        {
            MovePaddle();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void MovePaddle()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(leftKey))
        {
            movement += leftDirection * speed;
        }
        if (Input.GetKey(rightKey))
        {
            movement += rightDirection * speed;
        }

        transform.position += movement * Time.deltaTime;
    }
}