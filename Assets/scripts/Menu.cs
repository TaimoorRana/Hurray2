using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {
    // Use this for initialization
    public Button RestartButton;
    public Button PauseButton;
    public Button ExitButton2;
    public Button reprise;

    void Start()
    {
        Time.timeScale = 0.0f;
    }
    public void Lecture()
    {
        Time.timeScale = 1.0f;
        GameObject.FindWithTag("StartButton").SetActive(false);
        GameObject.FindWithTag("JoinButton").SetActive(false);
        GameObject.FindWithTag("ExitButton").SetActive(false);
        GameObject.FindWithTag("URL").SetActive(false);

    }
    public void Pause()
    {
        Time.timeScale = 0.0f;
        reprise.gameObject.SetActive(true);
        MoveInHierarchy(-1);
        //(Instantiate(RestartButton, RestartButton.transform.position, Quaternion.identity) as GameObject).transform.parent = GameObject.FindWithTag("CanvasUI").transform;
        RestartButton.gameObject.SetActive(true);

    }

    void Update(){
    	if(Input.GetKeyDown(KeyCode.A)){
			ExitButton2.gameObject.SetActive(true);
            PauseButton.gameObject.SetActive(true);
    	}
    }
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void Lecture1()
    {
        Time.timeScale = 1.0f;
        RestartButton.gameObject.SetActive(false);
        MoveInHierarchy(1);
    }

    public void MoveInHierarchy(int delta)
    {
        int index = PauseButton.transform.GetSiblingIndex();
        PauseButton.transform.SetSiblingIndex(index + delta);
    }
}
