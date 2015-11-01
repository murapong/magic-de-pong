using UnityEngine;
using System.Collections;

public class Score
{
	private static int magicCount = 3;
	private static int hightScore = 0;
	public static int GetMagicCount() { return magicCount;}

	public static void Initialize()
	{
		magicCount = 0;
	}
	public static void UseMagic(int rare)
	{
		magicCount+= rare;
	}
}
