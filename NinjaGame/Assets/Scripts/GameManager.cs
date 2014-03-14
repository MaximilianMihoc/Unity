using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	//Player Life texture
    public Texture playerLifeTexture;

    //Screen position for texture
    public float screenPositionX;
    public float screenPositionY;

    //Control icin size on screen
    public int iconSizeX = 25;
    public int iconSizeY = 25;

    //player lives
    public int playerHealth = 3;

    private WinText winText;

    void Awake()
    {
        winText = GetComponent<WinText>();
    }

    void OnGUI()
    {
        if (playerHealth <= 0)
        {
            playerHealth = 0;
            winText.lost = true;
        }

        //Control Player Healt Texture
        for(int h = 0; h < playerHealth; h++)
        {
            GUI.DrawTexture(new Rect(screenPositionX + (h * iconSizeX), screenPositionY, iconSizeX, iconSizeY),playerLifeTexture,ScaleMode.ScaleToFit,true,0);
        }

    }
}
