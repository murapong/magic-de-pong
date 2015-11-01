using UnityEngine;
using System.Collections;

public class ConfigData
{
	//魔法陣の判定用ボタンを表示するかどうか
	public static bool ShowMagicButton = true;
	//戦闘時間
	public static int BattleTime = 50;
    //属性が有利な時のダメージ
    public static float StrongElementDamage = 2f;
    //属性が不利な時のダメージ
    public static float WeakElementDamage = 0.2f;
    public static int Rare1Damage = 50;
    public static int Rare2Damage = 100;
    public static int Rare3Damage = 300;
    public static int Rare4Damage = 1000;
}
