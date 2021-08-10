using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : Paddle
{
    private Vector3 pos;
    private bool direction;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        direction = true;
    }

    //AI moves at half speed
    public override void GoUp(float speed)
    {
        pos.y += speed / 2;
    }

    public override void GoDown(float speed)
    {
        pos.y -= speed / 2;
    }

    //Goes up until it reaches the top, then goes down until it reaches the bottom
    public override void UpdatePosition(float speed)
    {
        if (direction)
        {
            GoUp(speed);
            if (pos.y >= 3.5)
                direction = !direction;
        }
        else
        {
            GoDown(speed);
            if (pos.y <= -3.5)
                direction = !direction;
        }
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
