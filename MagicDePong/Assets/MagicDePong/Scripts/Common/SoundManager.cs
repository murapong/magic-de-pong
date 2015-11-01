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

    #endregion

    #region AudioSource

    AudioSource audioSourceYes;

    AudioSource audioSourceAppear;

    AudioSource audioSourceDie;

    AudioSource audioSourceBGM;

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

    #endregion

    #region private method

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
    }

    #endregion
}
