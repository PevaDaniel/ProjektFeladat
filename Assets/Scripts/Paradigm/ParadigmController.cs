using TMPro;
using UnityEngine;

public class ParadigmController : MonoBehaviour
{
    public GameObject deathPanel;

    Rigidbody2D rb;
    Animator anim;

    public float speed = 5f;
    public float jumpForce = 5f;
    float move;

    public int toStringCount = 0;
    TextMeshProUGUI powerUpText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        powerUpText = GameObject.Find("PowerUpText").GetComponent<TextMeshProUGUI>();
        UpdatePowerUpUI();
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
    }

    void HandleMovement()
    {
        move = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

        anim.SetFloat("sped", Mathf.Abs(move));

        if (move < 0)
            anim.SetInteger("dir", 0);
        else if (move > 0)
            anim.SetInteger("dir", 1);
    }

    void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        if (anim.GetInteger("dir") == 1)
            anim.SetTrigger("jump_right");
        else
            anim.SetTrigger("jump_left");
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.name.Contains("double"))
        {
            if (toStringCount > 0)
            {
                toStringCount--;
                UpdatePowerUpUI();
            }
            else
            {
                Die();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name.Contains("ToString"))
        {
            toStringCount++;
            UpdatePowerUpUI();
            Destroy(col.gameObject);
        }

        if (col.name.Contains("Projectile"))
        {
            Die();
        }
    }

    void UpdatePowerUpUI()
    {
        powerUpText.text = "ToString(): " + toStringCount;
    }

    public void ShowDeathPanel()
    {
        deathPanel.SetActive(true);
    }

    void Die()
    {
        ShowDeathPanel();
        Debug.Log("Meghaltál!");
    }
}
