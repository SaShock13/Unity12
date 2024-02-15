using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("������ ����� ����")]
    [SerializeField] Canvas gameOverCanvas;

    [Header("�������� ������")]
    [SerializeField] GameObject mainCanvas;

    [Header("������ ����")]
    [SerializeField] GameObject ball;

    

    public void GameOver()
    {
        SceneManager.LoadScene(0);
        ball.SetActive(false);
        mainCanvas.SetActive(false);
        gameOverCanvas.enabled = true;
    }

    
}
