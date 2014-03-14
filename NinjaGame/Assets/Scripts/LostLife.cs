using UnityEngine;
using System.Collections;

public class LostLife : MonoBehaviour {

    public GameManager gameManager;
    public int damaged = 1;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Lava")
        {
            gameManager.SendMessage("PlayerDamage", damaged, SendMessageOptions.DontRequireReceiver);
        }
    }
}
