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
    private EnemyGenerator enemyGenerator;

    private GameManager()
    {
    }

    public void Initialize()
    {
        GameObject obj = GameObject.Find("EnemyGenerator");
        if (obj == null)
        {
            Debug.LogError("null");
            return;
        }
        enemyGenerator = obj.GetComponent<EnemyGenerator>();
        Score.Initialize();
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
            Score.UseMagic(data.rare);
            SoundManager.Instance.PlayEffectSEByName(data.effectName);

            EnemyController enemyObject = enemyGenerator.GetCurrentEnemy();
            if (enemyObject == null)
            {
                Debug.LogError("attack is failed");
                return;
            }
            Damage.Type type = Damage.GetType(data.element, enemyObject.data.element);
            enemyObject.OnAttacked(Damage.Get(data.rare, type), type, data.delayAttack);
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

    public void OnAllKilled()
    {
        Application.LoadLevel(Scenes.Result);
    }

    /// <summary>
    /// 次の敵を登場させる。
    /// </summary>
    public void GenerateEnemy()
    {
        EnemyGenerator.Instance.AppearNext();
    }
}
