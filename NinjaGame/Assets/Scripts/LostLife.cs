using UnityEngine;
using System.Collections;

public class LostLife : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Lava")
        {
            Time.timeScale = 0;
            //gameManager.playerHealth -= 1;
            RestartScene();
        }
    }

    void RestartScene()
    {
        Time.timeScale = 1;
        gameManager.playerHealth -= 1;
        Application.LoadLevel(Application.loadedLevel);
    }
}
