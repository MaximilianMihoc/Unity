using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public GUIText coinstext;
	public int curcoins;
	public int maxCoins = 10;

	//public GameObject otherGameObject;
	private WinText winText;

	void Awake()
	{
		winText = GetComponent<WinText>();
	}

	void Update()
	{
		coinstext.text = "Score: " + curcoins + "/" + maxCoins;

		if (curcoins >= maxCoins)
		{
			curcoins = maxCoins;
			Time.timeScale = 0;
			winText.win = true;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Coin")
		{
			Destroy (col.gameObject);
			curcoins ++;
		}

	}
}
