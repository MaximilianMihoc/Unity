using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    public GameManager gameManager;
	public GUIText coinstext;
	public int curcoins;
	public int maxCoins = 30;

	private WinText winText;

    public static bool allowShurikanes = true, allowArrows = true;

	void Awake()
	{
		winText = GetComponent<WinText>();
	}

	void Update()
	{
		coinstext.text = "Coins: " + curcoins;

        if (curcoins >= 25)
            allowShurikanes = true;

        if (curcoins >= 40)
            allowArrows = true;

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
            Destroy(col.gameObject);
            curcoins++;
            gameManager.SendMessage("RaiseScore", 250, SendMessageOptions.DontRequireReceiver);
        }
        if (col.gameObject.tag == "SpecialCoin1")
        {
            Destroy(col.gameObject);
            curcoins += 5;
            gameManager.SendMessage("RaiseScore", 500, SendMessageOptions.DontRequireReceiver);
        }
	}
}
