﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberAnimator : MonoBehaviour {
    private Text text;
    private int frame;
    private int scoreNow;
    private int scoreTo;
    private bool shouldStartAnimation;

    public void StartAnimation(int number)
    {
        scoreTo = number;
        shouldStartAnimation = true;
    }

    void Start ()
    {
        text = GetComponent<Text>();
        frame = 0;
        scoreTo = 10;
        scoreNow = 0;
        shouldStartAnimation = false;
    }

    void Update ()
    {
        if (scoreNow >= scoreTo)
        {
            return;
        }
        if (!shouldStartAnimation)
        {
            return;
        }
        frame++;
        if (frame % 1 == 0)
        {
            if (scoreTo - scoreNow >= 130)
            {
                scoreNow += 87;
            }
            else if (scoreTo - scoreNow >= 30)
            {
                scoreNow += 10;
            }
            else
            {
                scoreNow++;
            }
            UpdateNumber();
        }
    }
    private void UpdateNumber()
    {
        if (scoreNow == scoreTo)
        {
            Hashtable table = new Hashtable();
            table.Add("x", 1.5);
            table.Add("y", 1.5);
            table.Add("time", 0.2);
            table.Add("oncomplete", "CompleteHandler");
            iTween.ScaleTo(gameObject, table);
        }
        text.text = scoreNow.ToString();
    }
    private void CompleteHandler()
    {
        Hashtable table = new Hashtable();
        table.Add("x", 1.1);
        table.Add("y", 1.1);
        table.Add("time", 0.2);
        iTween.ScaleTo(gameObject, table);
    }
}
