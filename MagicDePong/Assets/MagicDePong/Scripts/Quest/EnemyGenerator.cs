using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyGenerator : MonoBehaviour
{
    #region enum

    #endregion

    #region const
    #endregion

    #region public property

    public static EnemyGenerator Instance;

    #endregion

    #region private property

    [SerializeField]
    GameObject enemyObjectBase;
    [SerializeField]
    HPGauge hpGauge;
    [SerializeField]
    DamageNumber damageNumber;

    /// <summary>
    /// 現在の敵ID。
    /// </summary>
    int currentID = 0;

    private EnemyController enemyObject;
    #endregion

    #region public method

    /// <summary>
    /// 出現時処理。
    /// </summary>
    public void AppearNext()
    {
        // 次の敵へ
        currentID++;
        var go = Instantiate(enemyObjectBase) as GameObject;
        enemyObject = go.GetComponent<EnemyController>();
        enemyObject.ID = currentID;
        EnemyData data = EnemyData.Get(currentID - 1);
        if (data == null)
        {
            GameManager.Instance().OnAllKilled();
            return;
        }
        enemyObject.HP = data.hp;
        enemyObject.MaxHP = data.hp;
        enemyObject.hpGauge = hpGauge;
        enemyObject.hpGauge.SetPercent(1);
        enemyObject.Appear();
        enemyObject.data = data;
        enemyObject.damageNumber = damageNumber;        
        enemyObject.hpGauge.SetElement(data.element);

        Debug.Log("Enemy was appeard.");
        Debug.Log("ID : " + enemyObject.ID);
        Debug.Log("HP : " + enemyObject.HP);
    }
    public EnemyController GetCurrentEnemy()
    {
        return enemyObject;
    }
    #endregion

    #region private method

    #endregion

    #region event

    void Awake()
    {
        Instance = this;
    }
    public void Initialize()
    {
        currentID = 0;
    }

    #endregion

    #region enum

    #endregion

    #region const

    #endregion
}
