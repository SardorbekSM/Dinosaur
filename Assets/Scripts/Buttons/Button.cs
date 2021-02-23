using UnityEngine;

public class Button : MonoBehaviour
{
    public void Reloaded()
    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1;
    }
}
