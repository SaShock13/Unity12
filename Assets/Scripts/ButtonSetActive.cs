using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ButtonSetActive : MonoBehaviour
{
    [Header("Объект для выключения")]
    [SerializeField] GameObject obj;
    [Header("Объект UI Text для отображения подсаказки нажатия клавиши")]
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
            text.text = "Нажмите E для активации моста";
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
    /// Отслеживает нажатие клавиши E
    /// </summary>
    void KeyListener()
    {
        if (Input.GetKeyDown(KeyCode.E) & isInTrigger)
        {
            obj.SetActive(!obj.activeSelf);
        }
    }

    /// <summary>
    /// Корутина мигания текста посказки
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
