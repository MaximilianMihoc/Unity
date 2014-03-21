using UnityEngine;
using System.Collections;

public class SwordController : MonoBehaviour {

    void Start()
    {
        collider2D.enabled = false;
    }
	
	void Update () 
    {
	    if(Input.GetKeyDown(KeyCode.C))
        {
            collider2D.enabled = true;
        }
        else collider2D.enabled = false; 
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Cobra")
        {
            Destroy(col.gameObject);
        }
    }
}
