using UnityEngine;
using TMPro;
public class CarController : MonoBehaviour
{
    public TMP_Text txtScore;
    float score = 0;
    float input;
    Rigidbody2D rb;
    bool jump = false;
    public float speed;
    Transform feet;
    Vector2 feetBox;
    LayerMask groundMask;
    Animator anima;
    AudioSource src;
    public AudioClip jumpSound;

    public AudioClip coinSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        anima = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        src = GetComponent<AudioSource>();

        feet = transform.Find("Feet");
        feetBox = new Vector2(0.8f, 0.1f);
        groundMask = LayerMask.GetMask("Ground");


    }

    // Update is called once per frame
    void Update()
    {

        input = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(input * speed, rb.linearVelocity.y);
        anima.SetFloat("Speed", rb.linearVelocity.magnitude);
        score += Time.deltaTime;
        txtScore.text = score.ToString("0.0");
        var grounded = Physics2D.OverlapBox(feet.position, feetBox, 0, groundMask);
        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        if (jump)
        {
            jump = false;
            rb.AddForce(transform.up * 10.0f, ForceMode2D.Impulse);
            src.PlayOneShot(jumpSound);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
            UnityEngine.SceneManagement.SceneManager.LoadScene("Lose");
        }
void OnTriggerEnter2D(Collider2D collision) {
            if (collision.CompareTag("Coin")){ 
              Destroy(collision.gameObject);
               score += 5;
            src.PlayOneShot(coinSound);
            }
       
        }
}
