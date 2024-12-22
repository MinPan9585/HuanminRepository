using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Rigidbody rb;
    public float force;

    
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //rb.AddForce(new Vector3(force, 0, 0) * Time.deltaTime);
            rb.velocity = new Vector3(force, 0, 0);
            //transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //rb.AddForce(new Vector3(-force, 0, 0) * Time.deltaTime);
            rb.velocity = new Vector3(-force, 0, 0);
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            //rb.AddForce(new Vector3(0, 0, force) * Time.deltaTime);
            rb.velocity = new Vector3( 0, 0, force);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //rb.AddForce(new Vector3(0, 0,-force) * Time.deltaTime);
            rb.velocity = new Vector3(0, 0, -force);
        }

        
    }
}
