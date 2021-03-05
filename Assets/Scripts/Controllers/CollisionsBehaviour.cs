using UnityEngine;
using UnityEngine.Events;

public class CollisionsBehaviour : MonoBehaviour
{
    [SerializeField]
    private UnityGameObjectEvent _notify;

    [SerializeField]
    private UnityEvent _gameEndNotify;

    [SerializeField, TagSelector]
    private string[] _tagFilterArray = new string[] { };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(_tagFilterArray[0]))
        {
            _gameEndNotify?.Invoke();
        }
        if (collision.gameObject.CompareTag(_tagFilterArray[1]))
        {
            _notify.Invoke(collision.gameObject);
        }
    }
}
