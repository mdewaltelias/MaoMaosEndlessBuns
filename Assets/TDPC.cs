using UnityEngine;

public class TDPC : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    float speed = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = move * speed;
    }
}
