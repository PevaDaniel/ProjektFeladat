using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Play()
    {
        SceneManager.LoadScene("lobby");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
