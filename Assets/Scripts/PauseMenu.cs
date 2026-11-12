using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject Container;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            OpenPauseMenu(); //executes function Openpausemenu when escape key pressed
        }
    }

    // Update is called once per frame
    public void OpenPauseMenu()
    {
            Container.SetActive(true); //Displays container (game paused menu)
            Time.timeScale = 0f;
    }
    public void ResumeButton()
    {
        Container.SetActive(false); //Removes container
        Time.timeScale = 1f;
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // Loads scene called "MainMenu"
    }
}
