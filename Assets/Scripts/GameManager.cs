using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public bool isPaused = false;

    public void SetGamePause()
    {
        Time.timeScale = 0;
        //isPaused = true;
    }

    public void SetGameContinue()
    {
        Time.timeScale = 1;
    }
}
