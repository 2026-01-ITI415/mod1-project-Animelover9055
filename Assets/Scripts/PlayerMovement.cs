using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float maxX = 8f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveX, 0f, 0f);
        rb.AddForce(movement * speed);

        Vector3 pos = rb.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        rb.position = pos;
    }
}