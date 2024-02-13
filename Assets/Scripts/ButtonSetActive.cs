using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ButtonSetActive : MonoBehaviour
{
    [SerializeField] GameObject obj;
    bool isInTrigger = false;
    [SerializeField] TMP_Text text;

    private void Start()
    {
        obj.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInTrigger = true;
            text.text = "Нажмите E для активации моста";
            text.enabled = true;
            StartCoroutine(nameof(TextBlink));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {            
            isInTrigger = false;
            StopCoroutine(nameof(TextBlink));
            text.enabled = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&isInTrigger)
        {
            obj.SetActive(!obj.activeSelf); 
        }
    }

    IEnumerator TextBlink()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);    
            text.enabled = !text.enabled;
        }            
    }
}
