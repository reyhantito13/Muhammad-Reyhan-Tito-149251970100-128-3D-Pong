using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ScoreController scoreController;

    void Start()
    {
        scoreController.Init(this, gameObject.name);
    }
}
