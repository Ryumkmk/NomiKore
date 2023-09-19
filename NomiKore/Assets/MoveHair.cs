using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchZoo : MonoBehaviour
{
    private Rigidbody2D rbody2D;

    private float jumpForce = 350f;

    private int jumpCount = 0;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnClickZoo()
    {
        this.rbody2D.AddForce(transform.up * jumpForce);
    }
}