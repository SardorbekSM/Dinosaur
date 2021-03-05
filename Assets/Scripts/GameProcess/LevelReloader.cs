using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelReloader : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _notify;

    private string _sceneName = "SampleScene";

    public void Reloaded()
    {
        SceneManager.LoadScene(_sceneName);
        _notify?.Invoke();
    }
}
