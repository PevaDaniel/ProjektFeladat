using UnityEngine;

public class Key2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            door2 masodikAjto = FindAnyObjectByType<door2>();
            door1 elsoAjto = FindAnyObjectByType<door1>();

            if (masodikAjto != null)
            {
                collision.gameObject.transform.position = new Vector3(98.66f, -13.2f, 0f);
                Destroy(masodikAjto.gameObject);
                Destroy(elsoAjto.gameObject);
            }

            Destroy(gameObject);
        }
    }
}