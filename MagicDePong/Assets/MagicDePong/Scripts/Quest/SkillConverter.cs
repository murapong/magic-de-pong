using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SkillConverter {
    public static SkillData GetSkill(int skillId)
    {
        return SkillData.GetData(skillId);
    }
    public static SkillData GetSkill(List<int> numberList)
    {
        List<int> dataList = new List<int>();
        for (int i = 1; i < SkillData.DataCount; i++)
        {
            SkillData data = SkillData.GetData(i);
            if (data == null || data.combination.Count == 0)
                continue;
            if (CompareList(numberList, data.combination))
            {
                return data;
            }
        }
        return SkillData.GetData(0);
    }
    private static bool CompareList(List<int> numberList, List<int> dataList)
    {
        if (dataList.Count == 0)
        {
            return false;
        }
        int i = 0;
        foreach(int number in numberList)
        {
            if (dataList[i] == number)
            {
                i++;
                if (i == dataList.Count - 1)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
