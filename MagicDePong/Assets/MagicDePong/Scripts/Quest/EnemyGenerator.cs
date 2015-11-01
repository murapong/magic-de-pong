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
    GameObject enemyObject;
    [SerializeField]
    HPGauge hpGauge;

    /// <summary>
    /// 現在の敵ID。
    /// </summary>
    int currentID = 0;

    #endregion

    #region public method

    /// <summary>
    /// 出現時処理。
    /// </summary>
    public void AppearNext()
    {
        // 次の敵へ
        currentID++;
        var go = Instantiate(enemyObject) as GameObject;
        var enemy = go.GetComponent<EnemyController>();
        enemy.ID = currentID;
        EnemyData data = EnemyData.Get(currentID - 1);
        if (data == null)
        {
            GameManager.Instance().OnAllKilled();
        }
        enemy.HP = data.hp;
        enemy.MaxHP = data.hp;
        enemy.hpGauge = hpGauge;
        enemy.hpGauge.SetPercent(1);
        enemy.Appear();

        Debug.Log("Enemy was appeard.");
        Debug.Log("ID : " + enemy.ID);
        Debug.Log("HP : " + enemy.HP);
    }

    #endregion

    #region private method

    #endregion

    #region event

    void Awake()
    {
        Instance = this;
    }

    #endregion

    #region enum

    #endregion

    #region const

    #endregion
}
