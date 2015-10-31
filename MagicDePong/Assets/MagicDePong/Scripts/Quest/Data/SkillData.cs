using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillData
{
    public static int DataCount = 2;

    public string prefab;
    public List<int> combination;
    public int id;

    public static SkillData GetData(int i)
    {
        SkillData data = new SkillData();
        data.id = i;
        switch(i)
        {
            case 0:
                data.prefab = "fire01";
                data.combination.Add(40);
                data.combination.Add(41);
                data.combination.Add(42);
                data.combination.Add(43);
                data.combination.Add(44);
                //data.combination.Add(33);
                //data.combination.Add(22);
                //data.combination.Add(11);
                data.combination.Add(0);
                data.combination.Add(1);
                data.combination.Add(2);
                data.combination.Add(3);
                data.combination.Add(4);
                break;
            case 1:
                data.prefab = "blizzard";
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
        prefab = "";
        combination = new List<int>();
    }
}
