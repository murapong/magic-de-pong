using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clock : MonoBehaviour {
	[SerializeField]
	private Text text;
	private float time;

	void Start ()
	{
		time = ConfigData.BattleTime;
		UpdateTime();
	}
	void Update ()
	{
		if (time < 0)
			return;
		int preTime = (int)time;
		time -= Time.deltaTime;
		if ((int)time != preTime)
		{
			UpdateTime();
		}
		if (time <= 0)
		{
			GameManager.Instance().OnTimeOver();
		}
	}
	private void UpdateTime()
	{
		text.text = ((int)time).ToString();
	}
}
