using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreenUI : MonoBehaviour {

    public GameObject[] stars;
    public Text scoreText;

	public void ShowScore(int score, bool showStars, int starScore)
    {
        ShowStars(0);

        scoreText.text = score.ToString();
        if (showStars)
        {
            ShowStars(starScore);
        }
    }

    void ShowStars(int score)
    {
        for (int i = 0; i < stars.Length; i++)
           stars[i].SetActive(((i + 1) <= score));
        
    }
}
