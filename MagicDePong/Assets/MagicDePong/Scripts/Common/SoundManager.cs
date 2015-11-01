using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    #endregion

    #region public property

    public static SoundManager Instance;

    #endregion

    #region private property

    #region AudioClip

    /// <summary>
    /// 決定音。
    /// </summary>
    [SerializeField]
    AudioClip audioClipYesSE;

    /// <summary>
    /// 敵出現SE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipAppearSE;

    /// <summary>
    /// 敵死亡SE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipDieSE;

    /// <summary>
    /// トップBGM
    /// </summary>
    [SerializeField]
    AudioClip audioClipTopBGM;

    /// <summary>
    /// クエストBGM
    /// </summary>
    [SerializeField]
    AudioClip audioClipQuestBGM;

    /// <summary>
    /// リザルトBGM
    /// </summary>
    [SerializeField]
    AudioClip audioClipResultBGM;

    /// <summary>
    /// 絶対零度エフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipAbsolute;

    /// <summary>
    /// 通常攻撃エフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipAttack;

    /// <summary>
    /// ブリザードエフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipBlizzard;

    /// <summary>
    /// 火エフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipFire;

    /// <summary>
    /// 炎エフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipFlame;

    /// <summary>
    /// 氷エフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipIce;

    /// <summary>
    /// メテオエフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipMeteor;

    /// <summary>
    /// 雷エフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipThunder;

    /// <summary>
    /// 雷雨エフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipThunderStorm;

    /// <summary>
    /// 竜巻エフェクトSE。
    /// </summary>
    [SerializeField]
    AudioClip audioClipWhirl;

    #endregion

    #region AudioSource

    AudioSource audioSourceYes;

    AudioSource audioSourceAppear;

    AudioSource audioSourceDie;

    AudioSource audioSourceBGM;

    AudioSource audioSourceEffect;

    #endregion

    #endregion

    #region public method

    /// <summary>
    /// 決定音を再生する。
    /// </summary>
    public void PlayYesSE()
    {
        audioSourceYes.Play();
    }

    /// <summary>
    /// 敵出現SEを再生する。
    /// </summary>
    public void PlayAppearSE()
    {
        audioSourceAppear.Play();
    }

    /// <summary>
    /// 敵死亡SEを再生する。
    /// </summary>
    public void PlayDieSE()
    {
        audioSourceDie.clip = audioClipDieSE;
        audioSourceDie.loop = false;
        audioSourceDie.Play();
    }

    /// <summary>
    /// トップBGMを再生する。
    /// </summary>
    public void PlayTopBGM()
    {
        audioSourceBGM.clip = audioClipTopBGM;
        audioSourceBGM.loop = true;
        audioSourceBGM.Play();
    }

    /// <summary>
    /// クエストBGMを再生する。
    /// </summary>
    public void PlayQuestBGM()
    {
        audioSourceBGM.clip = audioClipQuestBGM;
        audioSourceBGM.loop = true;
        audioSourceBGM.Play();
    }

    /// <summary>
    /// リザルトBGMを再生する。
    /// </summary>
    public void PlayResultBGM()
    {
        audioSourceBGM.clip = audioClipResultBGM;
        audioSourceBGM.loop = true;
        audioSourceBGM.Play();
    }

    /// <summary>
    /// エフェクトに対応したSEを再生する。
    /// </summary>
    /// <param name="name">Name.</param>
    public void PlayEffectSEByName(string name)
    {
        audioSourceEffect.clip = GetAudioClipByName(name);
        audioSourceEffect.loop = false;
        audioSourceEffect.Play();
    }

    #endregion

    #region private method

    AudioClip GetAudioClipByName(string name)
    {
        AudioClip clip;
        
        switch (name)
        {
            case "hit_normal":
                clip = audioClipAttack;
                break;
            case "dmg_fire1":
                clip = audioClipFire;
                break;
            case "dmg_ice1":
                clip = audioClipIce;
                break;
            case "thunder02":
                clip = audioClipThunder;
                break;
            case "meteor01":
                clip = audioClipMeteor;
                break;
            case "blizzard":
                clip = audioClipBlizzard;
                break;
            case "whirlwind":
                clip = audioClipWhirl;
                break;
            case "fire01":
                clip = audioClipFlame;
                break;
            case "icebreak01":
                clip = audioClipAbsolute;
                break;
            case "thunderstorm":
                clip = audioClipThunderStorm;
                break;
            default:
                clip = null;               
                break;
        }

        return clip;
    }

    #endregion

    #region event

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        Instance = this;

        InitSound();
    }

    /// <summary>
    /// サウンドの初期化を行う。
    /// </summary>
    void InitSound()
    {
        audioSourceYes = gameObject.AddComponent<AudioSource>();
        audioSourceYes.clip = audioClipYesSE;
        audioSourceYes.loop = false;

        audioSourceAppear = gameObject.AddComponent<AudioSource>();
        audioSourceAppear.clip = audioClipAppearSE;
        audioSourceAppear.loop = false;

        audioSourceDie = gameObject.AddComponent<AudioSource>();

        audioSourceBGM = gameObject.AddComponent<AudioSource>();

        audioSourceEffect = gameObject.AddComponent<AudioSource>();
    }

    #endregion
}
