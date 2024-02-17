using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [Header("������ ������ �����")]
    [SerializeField] GameObject pausePanel;

    /// <summary>
    /// ������ ���� �� �����
    /// </summary>
    public void PauseButtonClick()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true) ;
    }

    /// <summary>
    /// ������� ���� � �����
    /// </summary>
    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    
    /// <summary>
    /// ������������� �������
    /// </summary>
    public void RestartLevel()
    {
        ResumeGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// ����� �� ����
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// ��������� � ������� ����
    /// </summary>
    public void BackToMenyButtonClick()
    {
        ResumeGame();
        SceneManager.LoadScene(0);
    }


}
