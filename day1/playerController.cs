using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;

    private bool faceRight = true;

    void Start()
    {
        rb = GetComponent <Rigidbody2D> ();
        
    }

    void Update()
    {
        //движение
        float moveX = Input.GetAxis ("Horizontal");
        rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);

        //прыжок
        if (Input.GetKeyDown (KeyCode.Space))
            rb.AddForce(Vector2.up * 8000);

        //разворот
        if (moveX > 0 && !faceRight)
            flip();
        else if (moveX < 0 && faceRight)
            flip();
    }

    void flip()
    {
        faceRight = !faceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
}
