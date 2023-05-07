using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(force , 0 , 0) * Time.deltaTime);
            //transform.position += new Vector3(0, 0, 0.05f);
            //transform.position = transform.position + new Vector3(0, 0, 0.01f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(-force, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 0, force) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector3(0, 0, -force) * Time.deltaTime);
        }
    }
}
