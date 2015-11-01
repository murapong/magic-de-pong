using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillData
{
    public static int DataCount = 2;

    public string effectName;
    public List<int> combination;
    public int id;
    public int rotationX;//奥への回転
    public float positionUp;
    public float positionRight;
    public float positionFront;
    public float aliveTime;//何秒表示するか
    public int skillIconWidth;//スキル名画像の横の長さ
    public int skillIconHeight;//スキル名画像の縦の長さ

    public static SkillData GetData(int i)
    {
        SkillData data = new SkillData();
        data.id = i;
        switch(i)
        {
            case 0:
                data.effectName = "fire01";
                data.rotationX = 45;
                data.positionUp = 2.9f;
                data.skillIconWidth = 500;
                data.skillIconHeight = 160;
                // data.combination.Add(40);
                // data.combination.Add(41);
                // data.combination.Add(42);
                // data.combination.Add(43);
                // data.combination.Add(44);
                //data.combination.Add(33);
                //data.combination.Add(22);
                //data.combination.Add(11);
                data.combination.Add(0);
                data.combination.Add(1);
                // data.combination.Add(2);
                // data.combination.Add(3);
                // data.combination.Add(4);
                break;
            case 1:
                data.effectName = "blizzard";
                data.positionUp = 2.9f;
                data.positionRight = - 12.9f;
                data.positionFront = 2.0f;
                data.combination.Add(31);
                data.combination.Add(32);
                data.combination.Add(33);
                data.combination.Add(23);
                data.combination.Add(13);
                data.combination.Add(12);
                data.combination.Add(11);
                data.combination.Add(21);
                break;
            default:
                Debug.LogError("skill data is not found: " + i);
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
        skillIconWidth = 100;
        skillIconWidth = 100;
    }
}
