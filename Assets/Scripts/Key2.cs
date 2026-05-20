using UnityEngine;

public class Key2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 1. Automatikusan megkeresi a door2-t a pályán (nem kell behúzni semmit!)
            door2 masodikAjto = FindAnyObjectByType<door2>();

            // 2. Ha megvan, nyomtalanul kitörli a pályáról az ajtót
            if (masodikAjto != null)
            {
                Destroy(masodikAjto.gameObject);
            }

            // 3. A kulcs is megsemmisül, mert felvettük
            Destroy(gameObject);
        }
    }
}