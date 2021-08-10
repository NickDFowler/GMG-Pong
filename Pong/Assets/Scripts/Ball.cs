using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public GameController controller;

    private float xDirection;
    private float yDirection;
    private Vector3 pos;

    //Sets to position, and calls the start after a wait to give the player time to react
    void Start()
    {
        pos = this.transform.position;
        Invoke("BallStart", 2);
    }

    //Randomly chooses a start direction
    void BallStart()
    {        
        float r = Random.Range(0, 2);
        if (r < 1)
            xDirection = -xSpeed;
        else
            xDirection = xSpeed;

        yDirection = ySpeed;
    }

    //Reset the ball to the middle
    void ResetPos()
    {
        xDirection = 0;
        yDirection = 0;
        this.transform.position = Vector3.zero;
        pos = Vector3.zero;
    }

    //Calls reset and to start again after a wait to give the player time to react
    void Restart()
    {
        ResetPos();
        Invoke("BallStart", 1);
    }
    
    //Detects when the ball collides with other objects. Top wall and paddles bounce the ball, goal scores
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            yDirection = -yDirection;
        }
        if (other.CompareTag("Paddle"))
        {
            xDirection = -xDirection * 1.25f;
        }
        if (other.CompareTag("Goal"))
        {
            string goal = other.gameObject.name;
            controller.Score(goal);
            Restart();
        }
    }

    //Moves the ball
    void Move()
    {
        pos.x += xDirection;
        pos.y += yDirection;
        this.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
