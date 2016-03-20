using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
    // Use this for initialization
    public void Lecture()
    {
        Time.timeScale = 1.0f;
    }
    public void Pause()
    {
        Time.timeScale = 0.0f;
    }
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void exit()
    {
        Application.Quit();
    }
}
