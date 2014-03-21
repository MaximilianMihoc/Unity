﻿using UnityEngine;
using System.Collections;

public class ThrowShurikane : MonoBehaviour {

    public Rigidbody2D shurikane;
    public Transform player;

    private CharacterControllerScript caracterRight;

    void Awake()
    {
        caracterRight = GetComponent<CharacterControllerScript>();
    }

	void Update ()
    {
	    if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D shurikanetInstance;
            shurikanetInstance = Instantiate(shurikane, player.position, player.rotation) as Rigidbody2D;
            if (caracterRight.facingRight) shurikanetInstance.AddForce(player.right * 1500);
            else shurikanetInstance.AddForce(player.right * -1500);
        }
	}
}
