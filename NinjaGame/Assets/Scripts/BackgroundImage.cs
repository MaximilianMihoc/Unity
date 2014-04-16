using UnityEngine;
using System.Collections;

public class BackgroundImage : MonoBehaviour {

    public Texture BackgroundTexture;

    void OnGUI()
    {
        //Display background texture
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), BackgroundTexture);
    }
}
