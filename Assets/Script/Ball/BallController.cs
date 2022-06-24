using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;

    private Rigidbody rig;

    private float updateSpeed = 12f;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    void Update()
    {
        rig.velocity = rig.velocity.normalized * updateSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PaddleController>() != null)
        {
            AudioManager.instance.PlaySFX(0);
        }
    }
}
