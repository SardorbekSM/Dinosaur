using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
            else
                Time.timeScale = 1;
        }
    }
}
