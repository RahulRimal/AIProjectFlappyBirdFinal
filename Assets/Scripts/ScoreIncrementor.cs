using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrementor : MonoBehaviour
{

    // public ScoreManager scoreManager;
    public GameObject coinSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreManager.score++;
        GameObject coinSoundObj = Instantiate(coinSound);
        Destroy(coinSoundObj, 3);
    }

}
