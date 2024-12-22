using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assemble : MonoBehaviour
{
    public string partName;
    public bool canAssemble = false;
    public Material matToChange;
    private MeshRenderer meshRend;
    private GameObject player1;
    private GameObject player2;
    AudioSource assembleSFX;

    private void Awake()
    {
        canAssemble = false;
        assembleSFX = GameObject.Find("assembleSFX").GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<carPart>() == null)
        { 
            return;
        
        }
        if (other.GetComponent<carPart>() != null)
        {
            if (other.GetComponent<carPart>().partName == partName)
            {
                canAssemble = true;
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<carPart>() == null) { return; }
        if (other.GetComponent<carPart>() != null)
        {
            if (other.GetComponent<carPart>().partName == partName)
            {
                canAssemble = false;
                    
            }
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (canAssemble && Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (player1.transform.childCount != 1)
                return;
            meshRend.material = matToChange;
            Destroy(player1.transform.GetChild(0).gameObject);
            canAssemble = false;
            assembleSFX.Play();
            GameManager.player1Score = GameManager.player1Score + 1;
            print("Player1:" + GameManager.player1Score);
        }

        if (canAssemble && Input.GetKeyDown(KeyCode.Space))
        {
            if (player2.transform.childCount != 1)
                return;
            meshRend.material = matToChange;
            Destroy(player2.transform.GetChild(0).gameObject);
            canAssemble = false;
            assembleSFX.Play();
            GameManager.player2Score = GameManager.player2Score + 1;
            print("Player2: " + GameManager.player2Score);
        }
    }
}
