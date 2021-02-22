using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : GameOver
{ 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Hide();
            canvas.SetActive(true);
        }

        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
