using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTest : MonoBehaviour
{
    //����ʱ��ʼ����
    public float timeleft;
    public Text CountdownTxt;

    public AudioClip countSound;

    private bool isCounting;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        isCounting = true;
        audioSource = this.GetComponent<AudioSource>();

        // ��ʼ������ʱ�ı�
        CountdownTxt.text = timeleft.ToString("0");

    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            timeleft -= Time.deltaTime;
            CountdownTxt.text = timeleft.ToString("0");

        }


        if (timeleft <= 0 && isCounting)
        {
            isCounting = false;
            audioSource.PlayOneShot(countSound);

        }
    }
}