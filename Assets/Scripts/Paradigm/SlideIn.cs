using UnityEngine;

public class SlideIn : MonoBehaviour
{
    public float slideSpeed = 5f;
    public float moveSpeed = 3f;

    private Vector3 targetPos;
    private bool slidingIn = true;

    void Start()
    {
        targetPos = transform.position;
        transform.position += Vector3.right * 5f;
    }

    void Update()
    {
        if (slidingIn)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, slideSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPos) < 0.1f)
                slidingIn = false;
        }
        else
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            if (IsOutOfScreen())
                Destroy(gameObject);
        }
    }

    bool IsOutOfScreen()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        return viewPos.x < -0.2f; 
    }
}
