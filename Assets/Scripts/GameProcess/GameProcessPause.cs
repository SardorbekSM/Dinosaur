using UnityEngine;

public class GameProcessPause : MonoBehaviour
{
    public void PauseOrPlay()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1f;
    }
}
