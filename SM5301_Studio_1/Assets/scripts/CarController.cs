using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody carRB;
    public float carforce;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            carRB.AddForce(new Vector3(-1.2f * carforce, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            carRB.AddForce(new Vector3(1.2f * carforce, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            carRB.AddForce(new Vector3(0, 0, -carforce) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            carRB.AddForce(new Vector3(0, 0, carforce) * Time.deltaTime);
        }
    }
}
