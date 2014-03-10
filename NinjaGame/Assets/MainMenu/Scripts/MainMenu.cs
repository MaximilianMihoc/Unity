/*
    Attached to Main Camera 
 */
using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public Texture BackgroundTexture;

    public float guiPlaceButtonX1 = .25f;

    public float guiPlaceButtonY1 = .25f;
    public float guiPlaceButtonY2 = .5f;
    public float guiPlaceButtonY3 = .75f;

    void OnGUI()
    {
        //Display background texture
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), BackgroundTexture);

        //Display Buttons
        if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY1, Screen.width * .5f, Screen.height * .1f), "Play Game"))
        {
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY2, Screen.width * .5f, Screen.height * .1f), "Options"))
        {
            print("Clicked Options"); 
        }

        if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY3, Screen.width * .5f, Screen.height * .1f), "Quit Game"))
        {
            Application.Quit();
        }
    }
}
