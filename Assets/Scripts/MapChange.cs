using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour
{
    public GameObject Building_4;
    public GameObject Building_10;
    public GameObject Building_1;
    public GameObject Building_4_floor3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == Building_4)
        {
            SceneManager.LoadScene("lobby_2");
        }
        if(collision.gameObject == Building_10)
        {
            SceneManager.LoadScene("lobby_4");
        }
        if(collision.gameObject == Building_1)
        {
            SceneManager.LoadScene("lobby");
        }
        if(collision.gameObject == Building_4_floor3)
        {
            SceneManager.LoadScene("lobby_3");
        }
    }
}
