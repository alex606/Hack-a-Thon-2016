using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private float distance = 0.5f;
    public float rotationSpeed;
    public Camera camera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += camera.transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= camera.transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= camera.transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += camera.transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, Time.deltaTime * rotationSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -Time.deltaTime * rotationSpeed, 0);
        }
    }
}
