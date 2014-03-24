using UnityEngine;
using System.Collections;

public class LostLife : MonoBehaviour {

    public GameManager gameManager;
    public int damaged = 1;

    public GUIText Procent;
    int LifeProcent = 100;

    void Update()
    {
        Procent.text = LifeProcent + " %";

        if(LifeProcent <= 0)
        {
            gameManager.SendMessage("PlayerDamage", damaged, SendMessageOptions.DontRequireReceiver);
            LifeProcent = 100;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Lava")
        {
            LifeProcent -= LifeProcent;
        }

        if (col.gameObject.tag == "Cobra")
        {
            LifeProcent -= 5;
        }

        if(col.gameObject.tag == "Enemy3")
        {
            LifeProcent -= 10;
        }
    }
}
