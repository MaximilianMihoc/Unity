using UnityEngine;
using System.Collections;

public class TimeText : MonoBehaviour {

	public GUIText timerText;
	//my COUNTDOWN timer
	public float timer = 30.00f;

	void Update () {
		timer -= Time.deltaTime;

		timerText.text = "Time: " + timer.ToString("0.00");

		if (timer <= 0)
		{
			timerText.text = "";
			Time.timeScale = 0;
		}
	}
}
