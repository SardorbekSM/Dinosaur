using UnityEngine;
using UnityEngine.Events;

public class CollisionsBehaviour : MonoBehaviour
{
    [SerializeField]
    private UnityGameObjectEvent _notify;

    [SerializeField]
    private UnityEvent _gameEndNotify;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            _gameEndNotify?.Invoke();
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            _notify.Invoke(collision.gameObject);
        }
    }
}
