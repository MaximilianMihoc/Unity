using UnityEngine;
using System.Collections;

public class WinText : MonoBehaviour {

	public GUIText winText;
	public bool win = false;

	private Coin coins;
	
	void Awake()
	{
		coins = GetComponent<Coin>();
	}

	// Update is called once per frame
	void Update () 
	{
		if(win) 
			winText.text = "YOU WON!" + "\n" + "Click anywhere to restart";

		if (Input.GetMouseButtonDown (0)) 
		{
			RestartScene();
		}
	}

	void RestartScene()
	{
		coins.curcoins = 0;
		Time.timeScale = 1;
		Application.LoadLevel (Application.loadedLevel);
	}
}
