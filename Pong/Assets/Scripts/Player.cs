using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Paddle
{
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    //Adds the speed to the y position 
    public override void GoUp(float speed)
    {
        pos.y += speed;
    }

    //Subtracts the speed from the y position
    public override void GoDown(float speed)
    {
        pos.y -= speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos;
    }
}
