using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberAnimator : MonoBehaviour {
	private Text text;
	private int frame;
	private int scoreNow;
	private int scoreTo;

	void Start ()
	{
		text = GetComponent<Text>();
		frame = 0;
		scoreTo = 100;
		scoreNow = 0;
	}

	void Update ()
	{
		if (scoreNow >= scoreTo)
		{
			return;
		}
		frame++;
		if (frame % 1 == 0)
		{
			scoreNow++;
			UpdateNumber();
		}
	}
	private void UpdateNumber()
	{
		text.text = scoreNow.ToString();
	}
}
