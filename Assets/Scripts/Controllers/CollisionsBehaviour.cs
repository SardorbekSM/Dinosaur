using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CollisionsBehaviour : MonoBehaviour
{
    [SerializeField]
    private EventManager notify;

    [SerializeField]
    private UnityEvent gameEndNotify;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameEndNotify?.Invoke();   
        } 
        if (collision.gameObject.CompareTag("Coin"))
        {
            notify.Invoke(collision.gameObject);
        }
    }
}
