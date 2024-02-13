using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [Header("Трансформ игрока для следования камерой")]
    [SerializeField] Transform playerTransform;

    [Header("Смещение камеры относительно игрока")]
    [SerializeField] Vector3 offset;

    private void Start()
    {
        transform.position = playerTransform.position + offset;
        transform.LookAt(playerTransform.position);
    }

    private void Update()
    {
        MoveCamera();
    }

    /// <summary>
    /// Меняет положение камеры со смещением от игрока
    /// </summary>
    void MoveCamera()
    {
        transform.position = playerTransform.position + offset;
    }
}
