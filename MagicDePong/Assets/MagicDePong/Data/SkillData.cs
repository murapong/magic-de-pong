using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillData
{
    public enum Element
    {
        Fire,
        Water,
        Wind,
    }
    public static int DataCount = 82;

    public string effectName;
    public List<int> combination;
    public int id;
    public int rotationX;//奥への回転
    public float positionUp;
    public float positionRight;
    public float positionFront;
    public float aliveTime;//何秒表示するか
    public int skillIconId;
    public int skillIconWidth;//スキル名画像の横の長さ
    public int skillIconHeight;//スキル名画像の縦の長さ
    public int rare;
    public Element element;
    public float delayAttack;

    public static SkillData GetData(int i)
    {
        SkillData data = new SkillData();
        data.id = i;
        switch(i)
        {
            case 0:
                data.effectName = "hit_normal";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 1;
                data.combination.Add(40);
                data.combination.Add(41);
                data.combination.Add(42);
                data.combination.Add(43);
                data.combination.Add(44);
                data.aliveTime = 10;
                break;
            case 1:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(40);
                data.combination.Add(41);
                data.combination.Add(42);
                data.combination.Add(43);
                data.combination.Add(44);
                data.aliveTime = 10;
                break;
            case 2:
                data.effectName = "dmg_fire1";
                data.rare = 2;
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(30);
                data.combination.Add(31);
                data.combination.Add(32);
                data.combination.Add(33);
                data.combination.Add(34);
                data.aliveTime = 10;
                break;
            case 3:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(20);
                data.combination.Add(21);
                data.combination.Add(22);
                data.combination.Add(23);
                data.combination.Add(24);
                data.aliveTime = 10;
                break;
            case 4:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(10);
                data.combination.Add(11);
                data.combination.Add(12);
                data.combination.Add(13);
                data.combination.Add(14);
                data.aliveTime = 10;
                break;
            case 5:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(0);
                data.combination.Add(1);
                data.combination.Add(2);
                data.combination.Add(3);
                data.combination.Add(4);
                data.aliveTime = 10;
                break;
            case 6:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(4);
                data.combination.Add(3);
                data.combination.Add(2);
                data.combination.Add(1);
                data.combination.Add(0);
                data.aliveTime = 10;
                break;
            case 7:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(14);
                data.combination.Add(13);
                data.combination.Add(12);
                data.combination.Add(11);
                data.combination.Add(10);
                data.aliveTime = 10;
                break;
            case 8:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(24);
                data.combination.Add(23);
                data.combination.Add(22);
                data.combination.Add(21);
                data.combination.Add(20);
                data.aliveTime = 10;
                break;
            case 9:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(34);
                data.combination.Add(33);
                data.combination.Add(32);
                data.combination.Add(31);
                data.combination.Add(30);
                data.aliveTime = 10;
                break;
            case 10:
                data.effectName = "dmg_fire1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 2;
                data.combination.Add(44);
                data.combination.Add(43);
                data.combination.Add(42);
                data.combination.Add(41);
                data.combination.Add(40);
                data.aliveTime = 10;
                break;
            case 11:
                data.effectName = "dmg_ice1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Water;
                data.rare = 2;
                data.combination.Add(40);
                data.combination.Add(31);
                data.combination.Add(22);
                data.combination.Add(13);
                data.combination.Add(4);
                break;
            case 12:
                data.effectName = "dmg_ice1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Water;
                data.rare = 2;
                data.combination.Add(44);
                data.combination.Add(33);
                data.combination.Add(22);
                data.combination.Add(11);
                data.combination.Add(0);
                break;
            case 13:
                data.effectName = "dmg_ice1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Water;
                data.rare = 2;
                data.combination.Add(0);
                data.combination.Add(11);
                data.combination.Add(22);
                data.combination.Add(33);
                data.combination.Add(44);
                break;
            case 14:
                data.effectName = "dmg_ice1";
                data.positionUp = 2f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Water;
                data.rare = 2;
                data.combination.Add(4);
                data.combination.Add(13);
                data.combination.Add(22);
                data.combination.Add(31);
                data.combination.Add(40);
                break;
            case 21:
                data.effectName = "thunder02";
                data.positionUp = 0f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 2;
                data.combination.Add(40);
                data.combination.Add(30);
                data.combination.Add(20);
                data.combination.Add(10);
                data.combination.Add(0);
                break;
            case 22:
                data.effectName = "thunder02";
                data.positionUp = 0f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 2;
                data.combination.Add(41);
                data.combination.Add(31);
                data.combination.Add(21);
                data.combination.Add(11);
                data.combination.Add(1);
                break;
            case 23:
                data.effectName = "thunder02";
                data.positionUp = 0f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 2;
                data.combination.Add(42);
                data.combination.Add(32);
                data.combination.Add(22);
                data.combination.Add(12);
                data.combination.Add(2);
                break;
            case 24:
                data.effectName = "thunder02";
                data.positionUp = 0f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 2;
                data.combination.Add(43);
                data.combination.Add(33);
                data.combination.Add(23);
                data.combination.Add(13);
                data.combination.Add(3);
                break;
            case 25:
                data.effectName = "thunder02";
                data.positionUp = 0f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 2;
                data.combination.Add(44);
                data.combination.Add(34);
                data.combination.Add(24);
                data.combination.Add(14);
                data.combination.Add(4);
                break;
            case 31:
                data.effectName = "meteor01";
                data.positionUp = 2f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Fire;
                data.rare = 3;
                delayAttack = 1f;
                data.combination.Add(1);
                data.combination.Add(11);
                data.combination.Add(21);
                data.combination.Add(31);
                data.combination.Add(41);
                data.combination.Add(42);
                data.combination.Add(43);
                data.combination.Add(33);
                data.combination.Add(23);
                data.combination.Add(13);
                data.combination.Add(3);
                break;
            case 41:
                data.effectName = "blizzard";
                data.positionUp = 3f;
                data.positionRight = -10f;
                data.positionFront = 2.0f;
                data.element = Element.Water;
                data.rare = 3;
                data.combination.Add(31);
                data.combination.Add(32);
                data.combination.Add(33);
                data.combination.Add(23);
                data.combination.Add(13);
                data.combination.Add(12);
                data.combination.Add(11);
                data.combination.Add(21);
                break;
            case 51:
                data.effectName = "whirlwind";
                data.positionUp = 1.3f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 3;
                data.combination.Add(42);
                data.combination.Add(33);
                data.combination.Add(24);
                data.combination.Add(13);
                data.combination.Add(2);
                data.combination.Add(11);
                data.combination.Add(20);
                data.combination.Add(31);
                break;
            case 52:
                data.effectName = "whirlwind";
                data.positionUp = 1.3f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 3;
                data.combination.Add(24);
                data.combination.Add(13);
                data.combination.Add(2);
                data.combination.Add(11);
                data.combination.Add(20);
                data.combination.Add(31);
                data.combination.Add(42);
                data.combination.Add(33);
                break;
            case 53:
                data.effectName = "whirlwind";
                data.positionUp = 1.3f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 3;
                data.combination.Add(2);
                data.combination.Add(11);
                data.combination.Add(20);
                data.combination.Add(31);
                data.combination.Add(42);
                data.combination.Add(33);
                data.combination.Add(24);
                data.combination.Add(13);
                break;
            case 54:
                data.effectName = "whirlwind";
                data.positionUp = 1.3f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 3;
                data.combination.Add(20);
                data.combination.Add(31);
                data.combination.Add(42);
                data.combination.Add(33);
                data.combination.Add(24);
                data.combination.Add(13);
                data.combination.Add(2);
                data.combination.Add(11);
                break;
            case 55:
                data.effectName = "whirlwind";
                data.positionUp = 1.3f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 3;
                data.combination.Add(42);
                data.combination.Add(31);
                data.combination.Add(20);
                data.combination.Add(11);
                data.combination.Add(2);
                data.combination.Add(13);
                data.combination.Add(24);
                data.combination.Add(33);
                break;
            case 56:
                data.effectName = "whirlwind";
                data.positionUp = 1.3f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 3;
                data.combination.Add(20);
                data.combination.Add(11);
                data.combination.Add(2);
                data.combination.Add(13);
                data.combination.Add(24);
                data.combination.Add(33);
                data.combination.Add(42);
                data.combination.Add(31);
                break;
            case 57:
                data.effectName = "whirlwind";
                data.positionUp = 1.3f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 3;
                data.combination.Add(2);
                data.combination.Add(13);
                data.combination.Add(24);
                data.combination.Add(33);
                data.combination.Add(42);
                data.combination.Add(31);
                data.combination.Add(20);
                data.combination.Add(11);
                break;
            case 58:
                data.effectName = "whirlwind";
                data.positionUp = 1.3f;
                data.positionRight = -1f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 3;
                data.combination.Add(24);
                data.combination.Add(33);
                data.combination.Add(42);
                data.combination.Add(31);
                data.combination.Add(20);
                data.combination.Add(11);
                data.combination.Add(2);
                data.combination.Add(13);
                break;
            case 61:
                data.effectName = "fire01";
                data.rotationX = 45;
                data.positionUp = 2.9f;
                data.skillIconWidth = 500;
                data.skillIconHeight = 160;
                data.element = Element.Fire;
                data.rare = 4;
                data.combination.Add(40);
                data.combination.Add(41);
                data.combination.Add(42);
                data.combination.Add(43);
                data.combination.Add(44);
                data.combination.Add(33);
                data.combination.Add(22);
                data.combination.Add(11);
                data.combination.Add(0);
                data.combination.Add(1);
                data.combination.Add(2);
                data.combination.Add(3);
                data.combination.Add(4);
                break;
            case 71:
                data.effectName = "icebreak01";
                data.positionUp = 1f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Water;
                data.rare = 4;
                data.combination.Add(40);
                data.combination.Add(41);
                data.combination.Add(42);
                data.combination.Add(43);
                data.combination.Add(44);
                data.combination.Add(34);
                data.combination.Add(24);
                data.combination.Add(14);
                data.combination.Add(4);
                data.combination.Add(3);
                data.combination.Add(2);
                data.combination.Add(1);
                data.combination.Add(0);
                data.combination.Add(10);
                data.combination.Add(20);
                data.combination.Add(30);
                break;
            case 81:
                data.effectName = "thunderstorm";
                data.positionUp = 1f;
                data.positionRight = 0f;
                data.positionFront = 2.0f;
                data.element = Element.Wind;
                data.rare = 4;
                data.combination.Add(40);
                data.combination.Add(30);
                data.combination.Add(20);
                data.combination.Add(10);
                data.combination.Add(0);
                data.combination.Add(1);
                data.combination.Add(2);
                data.combination.Add(12);
                data.combination.Add(22);
                data.combination.Add(32);
                data.combination.Add(42);
                data.combination.Add(43);
                data.combination.Add(44);
                data.combination.Add(34);
                data.combination.Add(24);
                data.combination.Add(14);
                data.combination.Add(4);
                break;
            default:
                Debug.LogWarning("skill data is not found: " + i);
                break;
        }
        return data;
    }
    private SkillData()
    {
        effectName = "";
        combination = new List<int>();
        rotationX = 0;
        positionUp = 0;
        positionRight = 0;
        positionFront = 0;
        aliveTime = 10;
        skillIconId = 0;
        skillIconWidth = 100;
        skillIconWidth = 100;
        element = Element.Fire;
        rare = 1;
        delayAttack = 0.1f;
    }
}
