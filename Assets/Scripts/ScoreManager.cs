using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int scoreCount = 0;

    void Start()
    {
    }

    void Update()
    {
        scoreText.text = "Score: " + scoreCount.ToString();
    }
}
