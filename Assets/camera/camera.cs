using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	WebCamTexture front;
	// Use this for initialization
	void Start () {
		WebCamTexture webcamTexture = new WebCamTexture();
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}	
	
	// Update is called once per frame
	void OnGUI () {
		if (webcamTexture.isPlaying)
		{
			if (GUILayout.Button("Pause"))
			{
				webcamTexture.Pause();
			}
			if (GUILayout.Button("Stop"))
			{
				webcamTexture.Stop();
			}
		}
		else
		{
			if (GUILayout.Button("Play"))
			{
				webcamTexture.Play();
			}
		}

	}
}

