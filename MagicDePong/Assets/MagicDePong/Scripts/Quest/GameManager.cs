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
    enum State
    {
        Wait,
        Attack,
    }
    private State state;
    private float stateTimer;

    private static GameManager instance;
    private EnemyGenerator enemyGenerator;
    public InputManager inputManager;

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
        state = State.Wait;
        stateTimer = 0;
    }

    public void OnInputEnd(List<int> numberList)
    {
        SkillData data = SkillConverter.GetSkill(numberList);
        Attack(data);
    }

    private void Attack(SkillData data)
    {
        if (data == null)
        {
            return;
        }
        if (state == State.Wait)
        {
            inputManager.SetElement(data.element);
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
            state = State.Attack;
            stateTimer = 1.0f;
        }
    }
    public void Update(float deltaTime)
    {
        if (state == State.Attack)
        {
            stateTimer -= deltaTime;
            if (stateTimer <= 0)
            {
                state = State.Wait;
                OnAttackLimitEnd();
            }
        }
    }
    private void OnAttackLimitEnd()
    {
        inputManager.OpenLock();
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
