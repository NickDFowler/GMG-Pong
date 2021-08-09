using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleGameController : MonoBehaviour
{
    public Player player1;
    public AI player2;
    public Ball ball;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    void P1Position()
    {
        if (Input.GetKey(KeyCode.W) && player1.transform.position.y < 3.5)
            player1.GoUp(speed);
        if (Input.GetKey(KeyCode.S) && player1.transform.position.y > -3.5)
            player1.GoDown(speed);
    }

    void P2Position()
    {
        player2.UpdatePosition(speed);
    }

    // Update is called once per frame
    void Update()
    {
        P1Position();
        P2Position();
    }
}
