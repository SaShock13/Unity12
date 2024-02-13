using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [Header("Объект панели выбора уровня")]
    [SerializeField] GameObject levelSelectPanel;

    [Header("Объект панели меню")]
    [SerializeField] GameObject menuPanel;

    [Header("Объект мяча")]
    [SerializeField] GameObject ball;

    /// <summary>
    /// Отключает и включает панели и объекты
    /// </summary>
    public void PlayButtonClick()
    {
        levelSelectPanel.SetActive(true);
        menuPanel.SetActive(false);
        ball.SetActive(false);
    }

    /// <summary>
    /// Загружает сцену с индексом, передаваемым в параметре
    /// </summary>
    /// <param name="index"></param>
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
