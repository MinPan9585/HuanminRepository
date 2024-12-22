using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int player1Score = 0;
    public static int player2Score = 0;
    public GameObject nextLevelButton;
    public static bool readaySuccess = false;
    public AudioSource bgm;
    public AudioSource victorySFX;


    private void Awake()
    {
        bgm = GameObject.Find("bgm").GetComponent<AudioSource>();
        victorySFX = GameObject.Find("victorySFX").GetComponent<AudioSource>();
        
    }


    public void Update()
    {

        if (player1Score + player2Score == 23)
        {
            if (readaySuccess == false)
            {
                bgm.Pause();
                print("Pause");
                victorySFX.Play();
                print("Play");
                readaySuccess = true;
                Time.timeScale = 0;
            }

            nextLevelButton.SetActive(true);
            if (Input.GetKeyDown(KeyCode.K))
            {
                SceneManager.LoadScene("Level_2_1");
            }

        }
        else
        {
            nextLevelButton.SetActive(false);
        }


    }
}
