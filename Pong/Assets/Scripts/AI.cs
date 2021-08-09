using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    private Vector3 pos;
    private bool direction;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        direction = true;
    }

    void GoUp(float speed)
    {
        pos.y += speed;
    }

    void GoDown(float speed)
    {
        pos.y -= speed;
    }

    public void UpdatePosition(float speed)
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
