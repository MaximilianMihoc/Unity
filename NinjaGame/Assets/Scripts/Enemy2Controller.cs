using UnityEngine;
using System.Collections;

public class Enemy2Controller : MonoBehaviour {

    public float speed = -0.9f;
    bool flip = true;
    float time = 0;

    void FixedUpdate()
    {

        rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag != "Platform" && flip)
        {
            speed = speed * (-1);
            Flip();
            flip = false;
            time = Time.time;
        }
        if (time + 0.2 < Time.time)
            flip = true;

    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
