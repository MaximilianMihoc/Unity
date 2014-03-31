﻿using UnityEngine;
using System.Collections;

public class CobraMovement : MonoBehaviour {

    public float speed = -0.9f;
    bool flip = true;
    float time = 0;
    int CobraLife = 100;

    void Update()
    {
        if (CobraLife <= 0) Destroy(gameObject);
    }

	void FixedUpdate () 
    {
        rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Lava")
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "FlipEnemy" && flip)
        {
            speed = speed * (-1);
            Flip();
            flip = false;
            time = Time.time;
        }
        if (time + 0.2 < Time.time)
            flip = true;

        if(col.gameObject.tag == "Arrow")
        {
            CobraLife -= 50;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Shurikane")
        {
            CobraLife -= 25;
            Destroy(col.gameObject);
        }
        
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
