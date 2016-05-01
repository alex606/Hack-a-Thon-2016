using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private float distance = 0.5f;
    public float jumpSpeed;
    public float rotationSpeed;
    public Camera camera;

    private bool inAir { get; set; }

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
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -Time.deltaTime * rotationSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!inAir)
            {
                rb.AddForce(Vector3.up * jumpSpeed);
                inAir = true;
            }
        }

    }
    void OnCollisionEnter(Collision other)
    {
        string colliderTag = other.collider.tag;
        if (colliderTag == "Floor" || colliderTag == "Wall")
        {
            inAir = false;
        }
    }
}
