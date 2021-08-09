using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    public void GoUp(float speed)
    {
        pos.y += speed;
    }

    public void GoDown(float speed)
    {
        pos.y -= speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos;
    }
}
