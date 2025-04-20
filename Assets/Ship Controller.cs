using UnityEngine;

public class ShipController : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    float speed = 4.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal"); 
        
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = move * speed; 
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Meteor")){

            print("Game Over");
        }
           
    }
}
