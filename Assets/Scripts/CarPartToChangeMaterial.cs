using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPartToChangeMaterial : MonoBehaviour
{
    public string partName;
    public bool canAssemble = false;
    public Material matToChange;
    private MeshRenderer meshRend;
    private GameObject player1;
    private GameObject player2;
    void Start()
    {
        meshRend = GetComponent<MeshRenderer>();
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<CarPart>() == null)
        {
            return;
        }
        if (other.GetComponent<CarPart>() != null)
        {
            if(other.GetComponent<CarPart>().partName == partName)
            {
                canAssemble = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CarPart>() == null)
        {
            return;
        }
        if (other.GetComponent<CarPart>() != null)
        {
            if (other.GetComponent<CarPart>().partName == partName)
            {
                canAssemble = false;
            }
        }
    }

    private void Update()
    {
        if (canAssemble && Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (player1.transform.childCount == 0)
                return;
            meshRend.material = matToChange;
            Destroy(player1.transform.GetChild(0).gameObject);
            //register
        }
        if (canAssemble && Input.GetKeyDown(KeyCode.Space))
        {
            if (player2.transform.childCount == 0)
                return;
            meshRend.material = matToChange;
            Destroy(player2.transform.GetChild(0).gameObject);
            //register
        }
    }
}
