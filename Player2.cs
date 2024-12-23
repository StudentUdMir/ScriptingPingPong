using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    private float movement;

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Vertical2");
        rb.velocity = new Vector3(rb.velocity.x, 0, movement * speed);
    }
}
