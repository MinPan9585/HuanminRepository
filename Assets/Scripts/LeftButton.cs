using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    public GameObject workTable;
    public GameObject slide;
    public float speed;
    public float workTableYRotation;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            //calculate slider position
            slide.transform.position -= new Vector3(speed,0,0) * Time.deltaTime;
            float xPos = slide.transform.position.x;
            xPos = Mathf.Clamp(xPos, 1f, 4.6f);
            slide.transform.position = new Vector3(xPos, slide.transform.position.y, slide.transform.position.z);

            //calculate worktable rotation
            //xPos == 1 , yRotation == 0
            //     == 4.6, y == 360
            //     == 2 , y == 100
            workTableYRotation = (xPos - 1) * 100;
            workTable.transform.rotation = Quaternion.Euler(0, workTableYRotation, 0);
        }
    }
}
