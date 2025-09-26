using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    bool canMove = true;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector3(3f, rb.velocity.y, 0.0f);
                transform.rotation = Quaternion.Euler(0, -90, 0);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector3(-3f, rb.velocity.y, 0.0f);
                transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            else
            {
                rb.velocity = new Vector3(0f, rb.velocity.y, 0.0f);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.001f)
            {
                rb.AddForce(new Vector3(0.0f, 50f, 0.0f), ForceMode.Impulse);
            }
        }
    }
}
