using UnityEngine;

public class CollisionsBehaviour : GameOverScene
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            Hide();
        if(collision.gameObject.CompareTag("Coin"))
            Destroy(collision.gameObject);
    }
}
