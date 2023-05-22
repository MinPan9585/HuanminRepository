using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static int phase = 0;

    private void Update()
    {
        if (score == 14)
        {
            phase = 1;
        }
        if(score == 18)
        {
            phase = 2;
            //show next level btn
        }
    }

    //public bool isPaused = false;
    public AudioSource bgm;

    public void SetGamePause()
    {
        Time.timeScale = 0;
        bgm.Pause();
        //isPaused = true;
    }

    public void SetGameContinue()
    {
        Time.timeScale = 1;
        bgm.Play();
    }
}
