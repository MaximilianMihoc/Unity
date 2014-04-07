using UnityEngine;
using System.Collections;

public class WitchController : MonoBehaviour {

    public float speed = -0.9f;
    bool flip = true;
    float time = 0;
    int WitchLife = 100;
    public Rigidbody2D witchFire;
    public GameObject player;

    void Update()
    {
        if (WitchLife <= 0)
        {
            Destroy(gameObject);
        }

        Rigidbody2D fireInstance;
        fireInstance = Instantiate(witchFire, transform.position, transform.rotation) as Rigidbody2D;
        fireInstance.AddForce(player.transform.position * 100);
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (flip && col.gameObject.tag != "WitchFire")
        {
            speed = speed * (-1);
            Flip();
            flip = false;
            time = Time.time;
        }
        if (time + 0.2 < Time.time)
            flip = true;

    }
    void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
