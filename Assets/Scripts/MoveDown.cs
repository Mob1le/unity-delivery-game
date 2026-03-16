using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 200.0f;
    private float zBounds = -30.0f;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * -speed);

        if (transform.position.z < zBounds)
        {
            Destroy(gameObject);
        }
    }
}
