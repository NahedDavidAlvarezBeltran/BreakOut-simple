﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Ball"))
        {
            Rigidbody2D rb;
            rb = col.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector3(rb.velocity.x, -rb.velocity.y);
            print("sandoias");
            Destroy(gameObject);

        }
    }
}
