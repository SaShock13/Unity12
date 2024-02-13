using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;

    public void PauseButtonClick()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true) ;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    
    public void RestartLevel()
    {
        ResumeGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenyButtonClick()
    {
        ResumeGame();
        SceneManager.LoadScene(0);
    }


}
