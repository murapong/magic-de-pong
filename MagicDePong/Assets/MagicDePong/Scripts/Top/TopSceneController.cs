using UnityEngine;
using System.Collections;

public class TopSceneController : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    #endregion

    #region public property

    #endregion

    #region private property

    #endregion

    #region public method

    public void OnQuestTapped()
    {
        SoundManager.Instance.PlayYesSE();
        
        Application.LoadLevel(Scenes.Quest);
    }

    public void OnHelpTapped()
    {
        SoundManager.Instance.PlayYesSE();

        Application.LoadLevel(Scenes.Help);
    }

    #endregion

    #region private method

    #endregion

    #region event

    void Start()
    {
        SoundManager.Instance.PlayTopBGM();
    }

    void Update()
    {

    }

    #endregion
}
