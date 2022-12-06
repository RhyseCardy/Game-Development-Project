using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static Score instance;

    public Text scoreText;
    public Text highscoreText;

    public static int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + " POINTS";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPointSmall()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
        
    }

    public void AddPointMedium()
    {
        score += 5;
        scoreText.text = score.ToString() + " POINTS";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
        
    }

    public void AddPointLarge()
    {
        score += 10;
        scoreText.text = score.ToString() + " POINTS";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
