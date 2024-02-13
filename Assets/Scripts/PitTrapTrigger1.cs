using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitTrapTrigger1 : MonoBehaviour
{
    [Header("Объект ловушки для активации")]
    [SerializeField] GameObject trap;

    Collider[] bodies;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TrapActivation();
        }
    }

    /// <summary>
    /// Активирует ловушку
    /// </summary>
    void TrapActivation()
    {
        Vector3 overlapBoxSize = new Vector3(10, 5, 10);
        overlapBoxSize = new Vector3(trap.transform.localScale.x * 5 - 0.5f, 5f, trap.transform.localScale.z * 5 - 0.5f);
        trap.SetActive(false);
        bodies = Physics.OverlapBox(trap.transform.position, overlapBoxSize);
        Animator anim = new Animator();
        foreach (var body in bodies)
        {
            anim = body.gameObject.GetComponent<Animator>();
            if (anim != null)
            {
                anim.enabled = false;
            }
        }
    }
}
