using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProcessPause : MonoBehaviour
{
    private void Awake()
    {
        
    }

    public void PauseOrPlay()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }
}
