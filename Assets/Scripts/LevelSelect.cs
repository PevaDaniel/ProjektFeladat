using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public GameObject LevelSelectMenu;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!LevelSelectMenu.activeSelf)
            {
                LevelSelectMenu.SetActive(true);
            }
        }
    }
    public void CloseLevelSelect()
    {
        LevelSelectMenu.SetActive(false);
    }
}
