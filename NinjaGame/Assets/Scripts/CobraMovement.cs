using UnityEngine;
using System.Collections;

public class CobraMovement : MonoBehaviour {

    public float speed = -0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        rigidbody2D.velocity = new Vector2(speed, rigidbody2D.velocity.y);
	}
}
