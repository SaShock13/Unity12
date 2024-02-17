using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [Header("Объект панели паузы")]
    [SerializeField] GameObject pausePanel;

    /// <summary>
    /// Ставит игру на паузу
    /// </summary>
    public void PauseButtonClick()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true) ;
    }

    /// <summary>
    /// Снимает игру с паузы
    /// </summary>
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    
    /// <summary>
    /// Перезапускает уровень
    /// </summary>
    public void RestartLevel()
    {
        ResumeGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Выход из игры
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// Возращает в главное меню
    /// </summary>
    public void BackToMenyButtonClick()
    {
        ResumeGame();
        SceneManager.LoadScene(0);
    }


}
