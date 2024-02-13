using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] Vector3 offset;

    private void Start()
    {
        transform.position = playerTransform.position + offset;
        transform.LookAt(playerTransform.position);
    }

    private void Update()
    {
        transform.position = playerTransform.position + offset;       
    }
}
