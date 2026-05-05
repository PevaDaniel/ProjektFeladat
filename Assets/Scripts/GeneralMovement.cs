using UnityEngine;

public class GeneralMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;

    public float speed = 5f;
    public float jumpForce = 5f;

    float move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        anim.SetFloat("sped", Mathf.Abs(move));

        if (move < 0)
        {
            anim.SetInteger("dir", 0);
        }
        else if (move > 0)
        {
            anim.SetInteger("dir", 1);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }        
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        if (anim.GetInteger("dir") == 1)
        {
            anim.SetTrigger("jump_right");
        }
        else
        {
            anim.SetTrigger("jump_left");
        }
    }
}
