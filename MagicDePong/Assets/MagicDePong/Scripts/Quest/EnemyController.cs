using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    #endregion

    #region public property

    public static EnemyController Instance;

    #endregion

    #region private property

    Animator animator;

    /// <summary>
    /// 敵ID
    /// </summary>
    int enemyID;

    #endregion

    #region public method

    /// <summary>
    /// 被ダメージ処理。
    /// </summary>
    /// <param name="point">被ダメージポイント。</param>
    public void OnDamaged(int point)
    {
        animator.Play("Damaged");
    }

    /// <summary>
    /// 出現時処理。
    /// </summary>
    public void Appear(int id)
    {
        if (id <= 0)
            return;
        
        var sp = Resources.Load<Sprite>("Sprites/Quest/Enemy/" + GetSpriteName(id));
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = sp;
    }

    /// <summary>
    /// 死亡時処理
    /// </summary>
    public void Die()
    {
        animator.Play("Die");
    }

    #endregion

    #region private method

    /// <summary>
    /// 画像ファイル名を取得する。
    /// </summary>
    /// <returns>画像ファイル名。</returns>
    /// <param name="id">敵ID。</param>
    string GetSpriteName(int id)
    {
        if (id <= 0)
            id = 1;
        
        return string.Format("monster{0:00}", id);
    }

    #endregion

    #region event

    void Awake()
    {
        Instance = this;

        enemyID = 1;

        animator = GetComponent<Animator>();
    }

    void Start()
    {

    }

    void Update()
    {

    }

    #endregion

    #region enum

    #endregion

    #region const

    #endregion
}
