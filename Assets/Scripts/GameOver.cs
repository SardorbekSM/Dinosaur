using UnityEngine;

public class GameOver : MonoBehaviour
{
    private bool _active = false;

    [SerializeField]
    protected GameObject canvas;

    private void Awake()
    {
        canvas.SetActive(_active);
    }

    protected virtual void Hide()
    {
        if (_active)
        {
            canvas.SetActive(!(_active = false));
        }
        else
        {
            canvas.SetActive(!(_active = true));                
        }
        Pause();
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
