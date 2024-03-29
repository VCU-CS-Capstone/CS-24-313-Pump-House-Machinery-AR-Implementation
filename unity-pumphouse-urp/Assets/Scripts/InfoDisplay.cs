using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoDisplay : MonoBehaviour
{
    private Canvas canvas;

    private void Start()
    {
        //obtain the reference to the canvas & disable it
        //the canvas must be a child of the Text Collider Object

        canvas = GetComponentInChildren<Canvas>();

        
        if (canvas != null)
        {
            canvas.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("unable to obtain reference to canvas gameobject");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // when the collider attached to the OVRCamera Rig's Hand Enters the area then enable the canvas
        if (other.CompareTag("Hand"))
        {
            if (canvas != null)
            {
                canvas.gameObject.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // when the collider attached to the OVRCamera Rig's Hand exits the area then disable the canvas
        if (other.CompareTag("Hand"))
        {
            if (canvas != null)
            {
                canvas.gameObject.SetActive(false);
            }
        }
    }
}
