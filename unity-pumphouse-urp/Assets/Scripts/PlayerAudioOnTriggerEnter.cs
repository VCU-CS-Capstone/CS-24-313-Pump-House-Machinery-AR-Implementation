using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioOnTriggerEnter : MonoBehaviour
{
    //boolean to see if animation is playing
    private bool isAnim = false;

    
    private AudioSource source;
    private string targetTag = "Player";
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    //method to see if player is colliding with sound zone
    private void OnTriggerEnter(Collider other)
    {
        while (isAnim)
        {
            if (other.CompareTag(targetTag))
            {
                source.Play();
            }
        }
        
    }

    //setter function for isAnim
    public void setIsAnim(bool anim)
    {
        isAnim = anim;
    }
}
