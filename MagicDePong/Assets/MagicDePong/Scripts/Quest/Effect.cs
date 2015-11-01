using UnityEngine;
using System.Collections;

public class Effect : MonoBehaviour {
	private float aliveTime;
	void Start () {
	
	}
	public void SetAliveTime(float time)
	{
		aliveTime = time;
	}
	void Update () {
		aliveTime -= Time.deltaTime;
		if (aliveTime < 0)
		{
			Destroy(gameObject);
		}
	}
}
