using UnityEngine;

public class LevelReloader : MonoBehaviour
{
    public void Reloaded()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
    }
}
