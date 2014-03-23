using UnityEngine;
using System.Collections;

public class ArrowControler : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 2.5f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Cobra" || col.gameObject.tag == "Enemy3")
        {
            Destroy(col.gameObject);
        }
    }
}
