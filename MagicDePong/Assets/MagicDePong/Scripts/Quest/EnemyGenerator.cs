using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyGenerator : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    /// <summary>
    /// 敵HP格納用のリスト
    /// </summary>
    static readonly List<int> HPs = new List<int>() {
        5,
        10,
        15,
        20,
        25,
        30,
        35,
        40,
        45,
        50,
        55,
        60,
        65,
        70,
        75,
        80,
        85,
        90,
        95,
        100,
    };

    #endregion

    #region public property

    public static EnemyGenerator Instance;

    #endregion

    #region private property

    [SerializeField]
    GameObject enemyObject;

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
        Debug.Log("Current ID is " + currentID);

        var go = Instantiate(enemyObject) as GameObject;
        var enemy = go.GetComponent<EnemyController>();
        enemy.ID = currentID;
        enemy.HP = HPs[currentID - 1];
        enemy.Appear();
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
