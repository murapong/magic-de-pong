using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager
{
    public static GameManager Instance()
    {
        if (instance == null)
        {
            instance = new GameManager();
        }
        return instance;
    }
    private static GameManager instance;
    private GameManager()
    {
    }
    public void OnInputEnd(List<int> numberList)
    {
        SkillData data = SkillConverter.GetSkill(numberList);
        if (data != null)
        {
            Debug.LogError("発動！" + data.prefab);
        }
    }
}
