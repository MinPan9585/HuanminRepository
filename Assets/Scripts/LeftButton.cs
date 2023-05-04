using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : MonoBehaviour
{
    public GameObject workTable;
    public GameObject slide;
    public float speed;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            slide.transform.position -= new Vector3(speed,0,0) * Time.deltaTime;
            float xPos = slide.transform.position.x;
            xPos = Mathf.Clamp(xPos, 1f, 4.5f);
            slide.transform.position = new Vector3(xPos, slide.transform.position.y, slide.transform.position.z);
        }
    }
}
