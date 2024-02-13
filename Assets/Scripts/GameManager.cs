using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   [SerializeField] Canvas gameOverCanvas;
    [SerializeField] GameObject mainCanvas;
    [SerializeField] GameObject ball;

    public void GameOver()
    {
        SceneManager.LoadScene(0);
        ball.SetActive(false);
        mainCanvas.SetActive(false);
        gameOverCanvas.enabled = true;
    }
}
