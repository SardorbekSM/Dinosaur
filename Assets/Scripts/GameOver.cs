using UnityEngine;

public class GameOver : MonoBehaviour
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
        Pause();
    }

    private bool Active(bool active)
    {
        canvas.SetActive(active);
        return !active;
    }

    private void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }
}
