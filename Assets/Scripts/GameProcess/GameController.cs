using UnityEngine;
using UnityEngine.Events;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _notify;

    private bool _active = false;

    private void Awake()
    {
        Active(_active);
    }

    public void Hide()
    {
        Active(!_active);
        _notify?.Invoke();
    }

    public bool Active(bool active)
    {
        gameObject.SetActive(active);
        return !active;
    }
}
