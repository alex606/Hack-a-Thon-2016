using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]

public class LiveTv : MonoBehaviour {

    public WWW wwwData;
    public string url = "https://becunningandfulloftricks.files.wordpress.com/2013/04/hedgehog_in_the_fog.ogg";
    public GUITexture gt;
    void Start()
    {
        wwwData = new WWW(url);
        gt = GetComponent<GUITexture>();
        gt.texture = wwwData.movie;
    }
    void Update()
    {
        MovieTexture m = gt.texture as MovieTexture;
        if (!m.isPlaying && m.isReadyToPlay)
            m.Play();

    }
}
