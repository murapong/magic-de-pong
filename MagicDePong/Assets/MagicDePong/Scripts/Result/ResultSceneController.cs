using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultSceneController : MonoBehaviour
{
    #region enum

    #endregion

    #region const

    #endregion

    #region public property

    #endregion

    #region private property

    [SerializeField]
    private NumberAnimator killNumber;
    [SerializeField]
    private NumberAnimator scoreAnimator;
    [SerializeField]
    private Text highScore;

    private int frame;

    #endregion

    #region public method

    public void OnTopPressed()
    {
        Application.LoadLevel(Scenes.Top);
    }

    #endregion

    #region private method

    #endregion

    #region event

    void Start()
    {
        SoundManager.Instance.PlayResultBGM();

        int score = 1000;
        highScore.text = score.ToString();
        frame = 0;
    }

    void Update()
    {
        frame++;
        if (frame == 16)
        {
            killNumber.StartAnimation();
        }
        if (frame == 80)
        {
            scoreAnimator.StartAnimation();
        }

    }

    #endregion
}
