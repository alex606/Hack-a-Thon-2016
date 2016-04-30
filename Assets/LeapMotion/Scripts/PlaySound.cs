using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

    private BoxCollider col;
    private AudioSource audio;

    void Start()
    {
        col = GetComponent<BoxCollider>();
        audio = GetComponent<AudioSource>();
    }


    void OnCollisionEnter(Collision other)
    {
        Debug.Log("hello");
        audio.Play();
    }
}
