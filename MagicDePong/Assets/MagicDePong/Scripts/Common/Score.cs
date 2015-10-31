using UnityEngine;
using System.Collections;

public class Score
{
	private static int magicCount = 0;
	private static int hightScore = 0;
	public static void Initialize()
	{
		magicCount = 0;
	}
	public static void UseMagic()
	{
		magicCount++;
	}
}
