 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookMenu : MonoBehaviour
{
    public static bool PauseBook = false;
    public KeyCode OpenBookMenu;

    public GameObject BookMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(OpenBookMenu))
        {
            if (PauseBook)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        BookMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseBook = false;
    }

    void Pause()
    {
        BookMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseBook = true;
    }
}
