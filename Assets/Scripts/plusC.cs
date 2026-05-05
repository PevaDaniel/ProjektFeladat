using UnityEngine;

public class plusC : MonoBehaviour
{
    float speed = 6.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    /* private void OnCollisionEnter2D(Collision2D collision)
     {
         //delete diz shiz
         Destroy(gameObject);
         Debug.Log(collision);
     }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
