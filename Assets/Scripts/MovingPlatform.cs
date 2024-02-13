using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Трансформ второй точки платформы")]
    [SerializeField] Transform target;

    [Header("Длительность движения в одну сторону")]
    [SerializeField] float duration;

    [Header("Длительность остановки платформы")]
    [SerializeField] float stopDuration;

    Vector3 startPosition; 
    float t;
    bool isForward = true;    

    private void Start()
    {
        t = 0;
        startPosition = transform.position;
        StartCoroutine(nameof(MovePlatform));
    }   

    /// <summary>
    /// Корутина движения платформы туда и обратно
    /// </summary>
    /// <returns></returns>
    IEnumerator MovePlatform()
    {
        while (true)
        {
            transform.position = Vector3.Lerp(startPosition, target.position, t);
            t = isForward ?t+ (Time.deltaTime / duration) : t+(Time.deltaTime / duration * -1);
            if (t >= 1 || t <= 0)
            {
                t = t <= 0 ? 0 : 1;
                isForward = !isForward;
                yield return new WaitForSeconds(stopDuration);
            }
            else yield return null;  
        }
    }
}
