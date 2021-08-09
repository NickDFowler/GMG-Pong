using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiGameController : MonoBehaviour
{
    public Player player1;
    public Player player2;
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
        if (Input.GetKey(KeyCode.UpArrow) && player2.transform.position.y < 3.5)
            player2.GoUp(speed);
        if (Input.GetKey(KeyCode.DownArrow) && player2.transform.position.y > -3.5)
            player2.GoDown(speed);
    }

    // Update is called once per frame
    void Update()
    {
        P1Position();
        P2Position();
    }
}
