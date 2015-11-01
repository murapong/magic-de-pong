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
        Attack(data);
    }

    private void Attack(SkillData data)
    {
        if (data != null)
        {
            Debug.LogError("発動！" + data.effectName);
            EffectManager.Instance.Show(data);
            Score.UseMagic();

//            EnemyController.Instance.OnDamaged(10);
        }
    }

    public void AttackDebug(int skillId)
    {
        SkillData data = SkillConverter.GetSkill(skillId);
        Attack(data);
    }

    public void OnTimeOver()
    {
        Application.LoadLevel(Scenes.Result);
    }
}
