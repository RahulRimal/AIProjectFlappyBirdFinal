using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public static int highScore;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
        highScoreText.text = highScore.ToString();
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

}
