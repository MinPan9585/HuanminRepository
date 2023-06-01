using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public static int phase = 0;
    public GameObject nextLevelBtn;
    public static bool readyNext = false;

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
            if (readyNext)
            {
                nextLevelBtn.SetActive(true);
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene("Racing Scene_0508");
                }
            }
            else
            {
                nextLevelBtn.SetActive(false);
            }
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
