﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool _movingRight = true;

    public Transform groundDetection;
    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false)
        {
            if (_movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                _movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                _movingRight = true;
            }
        }
    }
}
