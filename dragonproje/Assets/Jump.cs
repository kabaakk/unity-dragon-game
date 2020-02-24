using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    public int jumpspeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump();
            GetComponent<AudioSource>().Play();
        }

        if (transform.position.y > 8)
        {
            SceneManager.LoadScene("dragons");
        }

        if (transform.position.y < -8)
        {
            SceneManager.LoadScene("dragons");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Platform")
        {
            
            SceneManager.LoadScene("dragons");
        }

        if (collision.transform.tag == "Enemy")
        {
            SceneManager.LoadScene("dragons");
        }
    }

    public void jump()
    {
        rb.AddForce(Vector2.up * jumpspeed);
    }
}
