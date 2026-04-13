using UnityEngine;

public class Border : MonoBehaviour
{
    public float Border1_x = 13;
    public float Border1_y1 = -2;
    public float Border1_y2 = 25;
    public float Border4_x1 = 86;
    public float Border4_x2 = 113;
    public float Border4_y1 = 26;
    public float Border4_y2 = 27;
    public bool Building1 = true;
    public bool Building2 = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Building1 == true)
        {
            Border1();
        }else
        {
            Border2();
        }
    }

    public void Border1()
    {
        Building2 = false;
        if(transform.position.x > Border1_x)
        {
            transform.position = new Vector3(Border1_x, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -Border1_x)
        {
            transform.position = new Vector3(-Border1_x, transform.position.y, transform.position.z);
        }
        if(transform.position.y < Border1_y1)
        {
            transform.position = new Vector3(transform.position.x, Border1_y1, transform.position.z);
        }
        if(transform.position.y > Border1_y2)
        {
            transform.position = new Vector3(transform.position.x, Border1_y2, transform.position.z);
        }
    }
    public void Border2()
    {
        Building1 = false;
        if(transform.position.x < Border4_x1)
        {
            transform.position = new Vector3(Border4_x1, transform.position.y, transform.position.z);
        }
        if(transform.position.x > Border4_x2)
        {
            transform.position = new Vector3(Border4_x2, transform.position.y, transform.position.z);
        }
        if(transform.position.y > Border4_y1)
        {
            transform.position = new Vector3(transform.position.x, Border4_y1, transform.position.z);
        }
        if(transform.position.y < Border4_y2)
        {
            transform.position = new Vector3(transform.position.x, Border4_y2, transform.position.z);
        }
    }
}
