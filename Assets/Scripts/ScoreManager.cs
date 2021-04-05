using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score;
    public static int oldHighScore;

    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs.GetInt('highScore', highScore);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        // scoreText.text = score.ToString();

        oldHighScore = PlayerPrefs.GetInt("highScore");

        if(score > oldHighScore)
        {
            PlayerPrefs.SetInt("highScore", score);
        }

    }

}
