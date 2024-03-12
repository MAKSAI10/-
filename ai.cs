using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour
{
     public Transform player; // ����, �� ������� ����� ��������� ���������
    public float speed; // �������� ������������ ����������
    [Space (30)]    

    
    [Header ("��������� ��������� ���������")] 
    public float followDistance; // ���������, �� ������� ��������� ���������� ���������

    void Update()
    {
        // �������� ����������� � ������
        Vector3 direction = player.position - transform.position;
        direction.Normalize();

        // ��������� ��������� �� ������
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= followDistance)
        {
            // ���������� ���������� � ����������� � ������
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}