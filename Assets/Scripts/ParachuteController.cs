using UnityEngine;

public class ParachuteController : MonoBehaviour
{
    public float fallSpeed = 20f;
    public float slowFallSpeed = 5f;

    private bool parachuteOpened = false;
    private bool isGrounded = false;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            parachuteOpened = true;
            Debug.Log("Парашут відкрито!");
        }
    }

    void FixedUpdate()
    {
        if (!isGrounded)
        {
            float speed = parachuteOpened ? slowFallSpeed : fallSpeed;

            rb.linearVelocity = new Vector3(0, -speed, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;

            if (!parachuteOpened)
            {
                Debug.Log("Невдале приземлення!");
            }
            else
            {
                Debug.Log("Успішне приземлення!");
            }
        }
    }
}