using UnityEngine;
using System.Collections;

public class TopSceneController : MonoBehaviour {
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
        Application.LoadLevel(Scenes.Quest);
    }
    public void OnHelpTapped()
    {
        Application.LoadLevel(Scenes.Help);
    }
    #endregion

    #region private method

    #endregion

    #region event

    void Start () {
        Score.Initialize();
    }

    void Update () {

    }

    #endregion
}
