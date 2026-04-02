using UnityEngine;

public class Border : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 13)
        {
            transform.position = new Vector3(13, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -13)
        {
            transform.position = new Vector3(-13, transform.position.y, transform.position.z);
        }
        if(transform.position.y < -2)
        {
            transform.position = new Vector3(transform.position.x, -2, transform.position.z);
        }
        if(transform.position.y > 24)
        {
            transform.position = new Vector3(transform.position.x, 24, transform.position.z);
        }
    }
}
