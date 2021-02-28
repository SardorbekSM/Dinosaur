using UnityEngine;

public class GameOverScene : MonoBehaviour
{
    private bool _active = false;

    [SerializeField]
    protected GameObject canvas;

    private void Awake()
    {
        Active(_active);
    }

    protected virtual void Hide()
    {
        Active(!_active);
        Time.timeScale = 0;
    }

    private bool Active(bool active)
    {
        canvas.SetActive(active);
        return !active;
    }
}
