using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Канвас Конец игры")]
    [SerializeField] Canvas gameOverCanvas;

    [Header("Основной канвас")]
    [SerializeField] GameObject mainCanvas;

    [Header("Объект мяча")]
    [SerializeField] GameObject ball;

    

    public void GameOver()
    {
        SceneManager.LoadScene(0);
        ball.SetActive(false);
        mainCanvas.SetActive(false);
        gameOverCanvas.enabled = true;
    }

    
}
