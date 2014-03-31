using UnityEngine;
using System.Collections;

public class WinText : MonoBehaviour {

	//public GUIText winText;
	public bool win = false;
    public bool lost = false;

	private Coin coins;

    public float guiPlaceButtonX1 = .7f;
    public float guiPlaceMenuX = .25f;

    public float guiPlaceMenuY = .25f;
    public float guiPlaceButtonY2 = .5f;
    public float guiPlaceButtonY3 = .75f;
    public float guiPlaceButtonY4 = .80f;
    
    
	
	void Awake()
	{
		coins = GetComponent<Coin>();
        
	}

	// Update is called once per frame
	void OnGUI () 
	{
        GUIStyle customButton = new GUIStyle("button");
        customButton.fontSize = 40;
        if (win)
        {
            GUI.Box(new Rect(Screen.width * guiPlaceMenuX, Screen.height * guiPlaceMenuY, Screen.width * .3f, Screen.height * .7f), "Nice Job", customButton);
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY2, Screen.width * .2f, Screen.height * .05f), "Restart"))
                RestartScene();
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY3, Screen.width * .2f, Screen.height * .05f), "Level 2"))
                Application.LoadLevel(2);
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY4, Screen.width * .2f, Screen.height * .05f), "Main Menu"))
                Application.LoadLevel("MainMenu");
        }

        if (lost)
        {
            GUI.Box(new Rect(Screen.width * guiPlaceMenuX, Screen.height * guiPlaceMenuY, Screen.width * .3f, Screen.height * .7f), "GAME OVER", customButton);
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY2, Screen.width * .2f, Screen.height * .05f), "Restart"))
                RestartScene();
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY3, Screen.width * .2f, Screen.height * .05f), "Main Menu"))
                Application.LoadLevel("MainMenu");
        }
	}

	void RestartScene()
	{
		coins.curcoins = 0;
		Time.timeScale = 1;
		Application.LoadLevel (Application.loadedLevel);
	}
}
