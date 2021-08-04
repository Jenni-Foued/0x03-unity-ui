using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rb;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    // FixedUpdate
    void FixedUpdate()
    {
        if (verticalInput == 1)
        {
            rb.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
        }

        if (verticalInput == -1)
        {
            rb.AddForce(Vector3.back * speed, ForceMode.VelocityChange);
        }

        if (horizontalInput == 1)
        {
            rb.AddForce(Vector3.right * speed, ForceMode.VelocityChange);
        }

        if (horizontalInput == -1)
        {
            rb.AddForce(Vector3.left * speed, ForceMode.VelocityChange);
        }
    }
}
