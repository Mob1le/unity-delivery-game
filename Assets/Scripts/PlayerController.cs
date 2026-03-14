using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody playerRb;
    private float zBounds = 7.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalSpeed = Input.GetAxis("Horizontal");
        float verticalSpeed = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * verticalSpeed * speed);
        playerRb.AddForce(Vector3.right * horizontalSpeed * speed);

        if (transform.position.z > zBounds)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBounds);
        } else if (transform.position.z < -zBounds)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBounds);
        }
    }
}
