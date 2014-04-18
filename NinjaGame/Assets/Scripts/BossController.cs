using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour 
{
    public float speed = -0.9f;
    bool flip = true;
    float time = 0, time2 = 0;
    int BossLife = 100;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if (BossLife <= 90 && BossLife > 5)
        {
            if (speed < 0)
            {
                speed = -10;
            }
            else
            {
                
                speed = 10;
            }

            rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
            anim.SetBool("Dash",true);
        }

        if (BossLife <= 5 && BossLife > 0)
        {
            speed = 0;
            anim.SetBool("Fall", true);
            time2 = Time.time;
        }

        if (time2 != 0 && time2 + 1.5 < Time.time)
            Destroy(gameObject);
        
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Lava")
        {
            Destroy(gameObject);
        }

        if ((col.gameObject.tag == "Enemy3" || col.gameObject.tag == "Enemy2" || col.gameObject.tag == "FlipEnemy" || col.gameObject.tag == "Cobra") && flip)
        {
            speed = speed * (-1);
            Flip();
            flip = false;
            time = Time.time;
        }

        if (time != 0 && time + 0.2 < Time.time)
            flip = true;

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Arrow")
        {
            BossLife -= 5;
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Shurikane")
        {
            BossLife -= 2;
            Destroy(col.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Sword")
        {
            BossLife -= 10;
        }
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

	
}
