using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [Header("��������� ������ ��� ���������� �������")]
    [SerializeField] Transform playerTransform;

    [Header("�������� ������ ������������ ������")]
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
    /// ������ ��������� ������ �� ��������� �� ������
    /// </summary>
    void MoveCamera()
    {
        transform.position = playerTransform.position + offset;
    }
}
