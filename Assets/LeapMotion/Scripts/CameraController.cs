using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    float rotationY = 0.0f;
    float rotationX = 0.0f;

    public float sensX = 5000.0f;
    public float sensY = 5000.0f;

    public float minY = -45.0f;
    public float maxY = 45.0f;

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;

        rotationX += Input.GetAxis("Mouse X") * sensX * Time.deltaTime;
        rotationY += Input.GetAxis("Mouse Y") * sensY * Time.deltaTime;
        rotationY = Mathf.Clamp(rotationY, minY, maxY);
        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
