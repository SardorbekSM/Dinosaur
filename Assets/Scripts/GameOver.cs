using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private bool active = true;

    [SerializeField]
    protected GameObject canvas;

    private void Awake()
    {
        canvas.SetActive(false);

    }

    protected virtual void Hide()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (active)
            {
                canvas.SetActive(true);
                active = false;
            }
            else

            {
                canvas.SetActive(false); active = true;
            }

        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }
}
