﻿using UnityEngine;
using System.Collections;

public class InstantiateArrrow : MonoBehaviour {

    public Rigidbody2D arrow;
    public Transform player;

    private CharacterControllerScript caracterRight;

    void Awake()
    {
        caracterRight = GetComponent<CharacterControllerScript>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2") && Coin.allowArrows)
        {
            Rigidbody2D arrowInstance;
            arrowInstance = Instantiate(arrow, player.position, player.rotation) as Rigidbody2D;
            if (caracterRight.facingRight) arrowInstance.AddForce(player.right * 2500);
            else
            {
                arrowInstance.AddForce(player.right * -2500);
            }
        }
    }

}
