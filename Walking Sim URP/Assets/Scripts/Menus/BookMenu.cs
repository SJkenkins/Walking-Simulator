 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookMenu : MonoBehaviour
{
    public static bool PauseBook = false;
    public KeyCode OpenBookMenu;

    public PlayerMovement playerMovement;
    public PlayerCamera playerCamera;

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
        Cursor.lockState = CursorLockMode.Locked;
        playerMovement.enabled = true;
        playerCamera.enabled = true;
        BookMenuUI.SetActive(false);
       // Time.timeScale = 1f;
        PauseBook = false;

    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        BookMenuUI.SetActive(true);
        playerMovement.enabled = false;
        playerCamera.enabled = false;
        // Time.timeScale = 0f;
        PauseBook = true;

    }
}
