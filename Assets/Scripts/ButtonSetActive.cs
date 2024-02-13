using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ButtonSetActive : MonoBehaviour
{
    [Header("������ ��� ����������")]
    [SerializeField] GameObject obj;
    [Header("������ UI Text ��� ����������� ���������� ������� �������")]
    [SerializeField] TMP_Text text;

    bool isInTrigger = false;

    private void Start()
    {
        obj.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInTrigger = true;
            text.text = "������� E ��� ��������� �����";
            text.enabled = true;
            StartCoroutine(nameof(TextBlink));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            isInTrigger = false;
            StopCoroutine(nameof(TextBlink));
            text.enabled = false;
        }
    }

    private void Update()
    {
        KeyListener();
    }

    /// <summary>
    /// ����������� ������� ������� E
    /// </summary>
    void KeyListener()
    {
        if (Input.GetKeyDown(KeyCode.E) & isInTrigger)
        {
            obj.SetActive(!obj.activeSelf);
        }
    }

    /// <summary>
    /// �������� ������� ������ ��������
    /// </summary>
    /// <returns></returns>
    IEnumerator TextBlink()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);    
            text.enabled = !text.enabled;
        }            
    }
}
