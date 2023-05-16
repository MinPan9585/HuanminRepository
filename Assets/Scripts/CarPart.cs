using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPart : MonoBehaviour
{
    public string partName;
    public bool canPickUpP1 = false;
    public bool canPickUpP2 = false;
    GameObject player1;
    private GameObject player2;
    private void Awake()
    {
        canPickUpP1 = false;
        canPickUpP2 = false;
    }
    private void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1") && other.transform.childCount == 0)
        {
            //follow player
            canPickUpP1 = true;
            //this.transform.SetParent(other.transform);
        }
        if (other.CompareTag("Player2") && other.transform.childCount == 0)
        {
            canPickUpP2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player1") && other.transform.childCount == 0)
        {
            canPickUpP1 = false;
        }
        if (other.CompareTag("Player2") && other.transform.childCount == 0)
        {
            canPickUpP2 = false;
        }
    }

    private void Update()
    {
        if(canPickUpP1 && Input.GetKeyDown(KeyCode.Keypad0))
        {
            this.transform.SetParent(player1.transform);
            canPickUpP1 = false;
        }
        if (canPickUpP2 && Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.SetParent(player2.transform);
            canPickUpP2 = false;
        }
    }
}
