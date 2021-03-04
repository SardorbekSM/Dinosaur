using UnityEngine;
using UnityEngine.Events;

public class LevelReloader : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _notify;

    public void Reloaded()
    {
        Application.LoadLevel(Application.loadedLevel);
        _notify?.Invoke();
    }
}
