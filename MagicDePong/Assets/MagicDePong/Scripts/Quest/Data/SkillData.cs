using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillData
{
    public static int DataCount = 1;

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
                data.combination.Add(1);
                data.combination.Add(2);
                data.combination.Add(3);
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
