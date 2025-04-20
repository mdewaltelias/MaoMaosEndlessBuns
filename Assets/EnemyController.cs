using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = -4.0f;

    Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Destroy(this.gameObject, 7);

    }


    private void FixedUpdate()
    {
        rb.linearVelocityX = speed;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
