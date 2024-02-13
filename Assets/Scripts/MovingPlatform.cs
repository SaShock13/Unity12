using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform target;
    Vector3 startPosition; 
    float t;
    bool isForward = true;
    [SerializeField] float duration;

    private void Start()
    {
        t = 0;
        startPosition = transform.position;
       
        
        StartCoroutine(nameof(MovePlatform));
    }   

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
                yield return new WaitForSeconds(2);
            }
            else yield return null;            
            
            //if (isForward)
            //{
            //    t += Time.deltaTime / duration;
            //    if (t >= 1)
            //    {
            //        isForward = false;
            //        yield return new WaitForSeconds(2);
            //    } else  yield return null;
            //}
            //else
            //{

            //    t -= Time.deltaTime / duration;
            //    if (t <= 0)
            //    {
            //        isForward = true;
            //        yield return new WaitForSeconds(2);
            //    }else yield return null;
            //}

        }
    }
}
