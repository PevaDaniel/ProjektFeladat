using UnityEngine;
using UnityEngine.SceneManagement;

public class Border : MonoBehaviour
{
    public float Border1_x = 13;
    public float Border1_y1 = -2;
    public float Border1_y2 = 25;
    public float Border2_x1 = -11.5f;
    public float Border2_x2 = 13.7f;
    public float Border2_y1 = -36;
    public float Border2_y2 = 17;
    private string scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        if (scene == "lobby")
        {
            border();
        }
        else if (scene == "lobby_2")
        {
            border2();
        }
        else if (scene == "lobby_3")
        {
            border3();
        }
    }
    public void border()
    {
        if (transform.position.x > Border1_x)
        {
            transform.position = new Vector3(Border1_x, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -Border1_x)
        {
            transform.position = new Vector3(-Border1_x, transform.position.y, transform.position.z);
        }
        if (transform.position.y < Border1_y1)
        {
            transform.position = new Vector3(transform.position.x, Border1_y1, transform.position.z);
        }
        if (transform.position.y > Border1_y2)
        {
            transform.position = new Vector3(transform.position.x, Border1_y2, transform.position.z);
        }
    }
    public void border2()
    {
        if (transform.position.y > Border2_y2)
        {
            transform.position = new Vector3(transform.position.x, Border2_y2, transform.position.z);
        }
        if (transform.position.x < Border2_x1)
        {
            transform.position = new Vector3(Border2_x1, transform.position.y, transform.position.z);
        }
        if (transform.position.y < Border2_y1)
        {
            transform.position = new Vector3(transform.position.x, Border2_y1, transform.position.z);
        }
        if (transform.position.x > Border2_x2)
        {
            transform.position = new Vector3(Border2_x2, transform.position.y, transform.position.z);
        }
        if(transform.position.y < -8 && transform.position.x >= -0.3)
        {
            transform.position = new Vector3(transform.position.x, -8, transform.position.z);
        } else if (transform.position.y < -8 && transform.position.x >= -0.3)
        {
            transform.position = new Vector3(-0.2f, transform.position.y, transform.position.z);
        }
    }
    public void border3()
    {
        if (transform.position.y > Border2_y2)
        {
            transform.position = new Vector3(transform.position.x, Border2_y2, transform.position.z);
        }
        if (transform.position.x < Border2_x1)
        {
            transform.position = new Vector3(Border2_x1, transform.position.y, transform.position.z);
        }
        if (transform.position.y < Border2_y1)
        {
            transform.position = new Vector3(transform.position.x, Border2_y1, transform.position.z);
        }
        if (transform.position.x > Border2_x2)
        {
            transform.position = new Vector3(Border2_x2, transform.position.y, transform.position.z);
        }
        if (transform.position.y < -8 && transform.position.x >= -0.3)
        {
            transform.position = new Vector3(transform.position.x, -8, transform.position.z);
        }
        else if (transform.position.y < -8 && transform.position.x >= -0.3)
        {
            transform.position = new Vector3(-0.2f, transform.position.y, transform.position.z);
        }
    }
}
