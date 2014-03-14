using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//Player Life texture
    public Texture playerLifeTexture;
    public Texture playerHead;

    //Screen position for texture
    public float screenPositionX;
    public float screenPositionY;

    //Control icin size on screen
    public int iconSizeX = 25;
    public int iconSizeY = 25;

    //player lives
    public int playerHealth = 3;

    private WinText winText;
    public GameObject player;

    bool restart = false;

    void Awake()
    {
        winText = GetComponent<WinText>();
    }

    void OnGUI()
    {
        //Control Player Healt Texture
        GUI.DrawTexture(new Rect(screenPositionX - 50, screenPositionY, iconSizeX + 10, iconSizeY + 10), playerHead, ScaleMode.ScaleToFit, true, 0);
        for(int h = 0; h < playerHealth; h++)
        {
            GUI.DrawTexture(new Rect(screenPositionX + (h * iconSizeX), screenPositionY, iconSizeX, iconSizeY),playerLifeTexture,ScaleMode.ScaleToFit,true,0);
        }

        //rstart game if player lost only one life
        if (restart)
        {
            if (GUI.Button(new Rect(Screen.width * 0.5f, Screen.height * 0.5f, Screen.width * .2f, Screen.height * .1f), "Continue"))
                RestartScene();
        }
    }

    public void PlayerDamage(int damage)
    {
        if (playerHealth > 0)
        {
            playerHealth = playerHealth - damage;
            Time.timeScale = 0;
            restart = true;
        }

        if (playerHealth <= 0)
        {
            playerHealth = 0;
            winText.lost = false;
        }
        
    }

    void RestartScene()
    {
        Time.timeScale = 1;
        restart = false;
        player.transform.position = new Vector3(-3, 0, 0);
    }
}
