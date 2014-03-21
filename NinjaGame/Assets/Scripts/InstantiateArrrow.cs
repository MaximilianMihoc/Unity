using UnityEngine;
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
        if (Input.GetButtonDown("Fire2"))
        {
            Rigidbody2D arrowtInstance;
            arrowtInstance = Instantiate(arrow, player.position, player.rotation) as Rigidbody2D;
            if (caracterRight.facingRight) arrowtInstance.AddForce(player.right * 2500);
            else arrowtInstance.AddForce(player.right * -1500);
        }
    }
}
