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
	
	void Awake()
	{
		coins = GetComponent<Coin>();
	}

	// Update is called once per frame
	void OnGUI () 
	{
        if (win)
        {
            GUI.Box(new Rect(Screen.width * guiPlaceMenuX, Screen.height * guiPlaceMenuY, Screen.width * .5f, Screen.height * .7f), "Nice Job");
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY2, Screen.width * .2f, Screen.height * .1f), "Restart"))
                RestartScene();
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY3, Screen.width * .2f, Screen.height * .1f), "Main Menu"))
                Application.LoadLevel("MainMenu");

        }
        if (lost)
        {
            GUI.Box(new Rect(Screen.width * guiPlaceMenuX, Screen.height * guiPlaceMenuY, Screen.width * .5f, Screen.height * .7f), "GAME OVER");
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY2, Screen.width * .2f, Screen.height * .1f), "Restart"))
                RestartScene();
            if (GUI.Button(new Rect(Screen.width * guiPlaceButtonX1, Screen.height * guiPlaceButtonY3, Screen.width * .2f, Screen.height * .1f), "Main Menu"))
                Application.LoadLevel("MainMenu");
        }
			//winText.text = "YOU WON!" + "\n" + "Click anywhere to restart";

        //if (lost)
            //winText.text = "YOU LOST!" + "\n" + "Click anywhere to restart";

		/*if (Input.GetMouseButtonDown (0)) 
		{
			RestartScene();
		}*/
	}

	void RestartScene()
	{
		coins.curcoins = 0;
		Time.timeScale = 1;
		Application.LoadLevel (Application.loadedLevel);
	}
}
