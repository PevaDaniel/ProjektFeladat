using Unity.VisualScripting;
using UnityEngine;

public class MapChange : MonoBehaviour
{
    public GameObject Player;
    public GameObject Building_4;
    public GameObject Building_10;
    public GameObject Building_1;
    public GameObject Building_4_floor3;
    private Border border;
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
        if (collision.CompareTag("Player"))
        {
            if(collision.gameObject == Building_1)
            {
                Player.transform.position = new Vector3 (5.5f, 23f, transform.position.z);
                border.Building1 = true;
                border.Building2 = false;
            }
            if(collision.gameObject == Building_4)
            {
                Player.transform.position = new Vector3(90f, 25f, transform.position.z);
                border.Building1 = false;
                border.Building2 = true;
            }
        }
    }
}
