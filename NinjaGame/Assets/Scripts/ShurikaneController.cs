using UnityEngine;
using System.Collections;

public class ShurikaneController : MonoBehaviour {

    //public float ShSpeed = 10f;
    public float ShRotation = 20f;

    void Start()
    {
        Destroy(gameObject, 2.5f);
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, -ShRotation);
        //rigidbody2D.velocity = new Vector2(ShSpeed, rigidbody2D.velocity.y * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Cobra" || col.gameObject.tag == "Enemy3")
        {
            Destroy(col.gameObject);
        }
    }
}
