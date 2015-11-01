using UnityEngine;
using System.Collections;

public class Score
{
	private static int killCount = 0;
	private static int rank2Count = 0;
	private static int rank3Count = 0;
	private static int rank4Count = 0;
	private static int hightScore = 0;
	private static int timeLeft = 0;
	public static int GetKill() { return killCount;}
	public static int GetRank2() { return rank2Count;}
	public static int GetRank3() { return rank3Count;}
	public static int GetRank4() { return rank4Count;}
	public static int GetTime() { return timeLeft;}
	public static int GetTotalScore()
	{
		return killCount * 100
			+ rank2Count * 50
			+ rank3Count * 100
			+ rank4Count * 200
			+ timeLeft * 100;
	}

	public static void Initialize()
	{
		killCount = 0;
		rank2Count = 0;
		rank3Count = 0;
		rank4Count = 0;
		timeLeft = 0;
	}
	public static void UseMagic(int rare)
	{
		if (rare == 2)
		{
			rank2Count++;
		}
		if (rare == 3)
		{
			rank3Count++;
		}
		if (rare == 4)
		{
			rank4Count++;
		}
	}
	public static void KillEnemy()
	{
		killCount++;
	}
	public static void SetTime(int time)
	{
		timeLeft = time;
	}
}
