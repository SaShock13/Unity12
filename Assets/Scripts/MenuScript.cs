using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [Header("������ ������ ������ ������")]
    [SerializeField] GameObject levelSelectPanel;

    [Header("������ ������ ����")]
    [SerializeField] GameObject menuPanel;

    [Header("������ ����")]
    [SerializeField] GameObject ball;

    /// <summary>
    /// ��������� � �������� ������ � �������
    /// </summary>
    public void PlayButtonClick()
    {
        levelSelectPanel.SetActive(true);
        menuPanel.SetActive(false);
        ball.SetActive(false);
    }

    /// <summary>
    /// ��������� ����� � ��������, ������������ � ���������
    /// </summary>
    /// <param name="index"></param>
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
