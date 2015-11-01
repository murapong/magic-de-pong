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
    private NumberAnimator timeNumber;
    [SerializeField]
    private NumberAnimator killNumber;
    [SerializeField]
    private NumberAnimator star2Number;
    [SerializeField]
    private NumberAnimator star3Number;
    [SerializeField]
    private NumberAnimator star4Number;
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
        // highScore.text = score.ToString();
        frame = 0;
    }

    void Update()
    {
        frame++;
        if (frame == 16)
        {
            timeNumber.StartAnimation(Score.GetTime());
        }
        if (frame == 32)
        {
            killNumber.StartAnimation(Score.GetKill());
        }
        if (frame == 48)
        {
            star2Number.StartAnimation(Score.GetRank2());
        }
        if (frame == 64)
        {
            star3Number.StartAnimation(Score.GetRank3());
        }
        if (frame == 80)
        {
            star4Number.StartAnimation(Score.GetRank4());
        }
        if (frame == 100)
        {
            scoreAnimator.StartAnimation(Score.GetTotalScore());
        }

    }

    #endregion
}
