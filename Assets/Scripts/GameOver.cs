using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private bool _active = true;

    [SerializeField]
    protected GameObject canvas;

    private void Awake()
    {
        canvas.SetActive(false);

    }

    protected virtual void Hide()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (_active)
            {
                canvas.SetActive(true);
                _active = false;
            }
            else

            {
                canvas.SetActive(false);
                _active = true;
            }

        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }
}
