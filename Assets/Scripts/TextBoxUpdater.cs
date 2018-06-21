﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxUpdater : MonoBehaviour {
    private Text text;
    private int distance;
    private int score;

    private void Start()
    {

        distance = 0;
        text = this.GetComponent("Text") as Text;
    }

    void FixedUpdate ()
    {
        distance = distance + 1;
        score = distance / 10;
        text.text = "Score " + (distance / 10).ToString();
        StaticScoreClass.ScoreInformation = score;
    }
}