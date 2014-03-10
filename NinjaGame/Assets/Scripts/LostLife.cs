using UnityEngine;
using System.Collections;

public class LostLife : MonoBehaviour {

    public int Lives = 3;

    private WinText winText;
    void Awake()
    {
        winText = GetComponent<WinText>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Lava")
        {
            Time.timeScale = 0;
            winText.lost = true;
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
