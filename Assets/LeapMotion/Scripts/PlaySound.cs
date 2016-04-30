using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

    private BoxCollider col;
    private AudioSource audioSource;

    void Start()
    {
        col = GetComponent<BoxCollider>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Player")
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
                audioSource.Play();
            }
            else
            {
                audioSource.Play();
            }
        }
    }
}
