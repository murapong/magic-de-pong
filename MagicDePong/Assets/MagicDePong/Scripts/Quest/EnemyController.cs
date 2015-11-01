using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    /// <summary>
    /// ダメージフラグ名。
    /// </summary>
    const string flagNameIsDamaged = "IsDamaged";

    /// <summary>
    /// 死亡フラグ名。
    /// </summary>
    const string flagNameIsDead = "IsDead";

    #endregion

    #region public property

    /// <summary>
    /// 現在のHP。
    /// </summary>
    public int HP;

    /// <summary>
    /// 最大のHP。
    /// </summary>
    public int MaxHP;
    public HPGauge hpGauge;

    /// <summary>
    /// 敵ID。
    /// </summary>
    public int ID;

    #endregion

    #region private property

    Animator animator;

    #endregion

    #region public method

    public void Appear()
    {
        Debug.Log("Appear");

        // スプライトの設定
        var sp = Resources.Load<Sprite>("Sprites/Quest/Enemy/" + GetSpriteName(ID));
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = sp;

        SoundManager.Instance.PlayAppearSE();
    }

    /// <summary>
    /// 被ダメージ処理。
    /// </summary>
    /// <param name="point">被ダメージポイント。</param>
    /// <param name="delay">アニメーション遅延秒数</param>
    public void OnDamaged(int point, float delaySec = 0f)
    {
        Debug.Log("OnDamaged");

        HP = HP - point;
        hpGauge.SetPercent((float) HP / MaxHP);
        animator.SetBool(flagNameIsDamaged, true);
    }

    /// <summary>
    /// 死亡時処理
    /// </summary>
    public void Die()
    {
        Debug.Log("Die");

        animator.SetBool(flagNameIsDead, true);

        Invoke("DestorySelf", 3f);
    }

    /// <summary>
    /// アイドル時処理。
    /// </summary>
    public void Idle()
    {
        Debug.Log("Idle");

        animator.SetBool(flagNameIsDamaged, false);

        if (HP <= 0)
            Die();
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

    /// <summary>
    /// クリーニング処理
    /// </summary>
    void DestorySelf()
    {
        Destroy(gameObject);

        GameManager.Instance().GenerateEnemy();
    }

    #endregion

    #region event

    void Awake()
    {
        animator = GetComponent<Animator>();

        // フラグの初期化
        animator.SetBool(flagNameIsDamaged, false);
        animator.SetBool(flagNameIsDead, false);
    }

    void Start()
    {

    }

    void Update()
    {

    }

    #endregion
}
