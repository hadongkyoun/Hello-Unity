using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float sizeOfCircle = 30f;

        float radius = GetRadius(sizeOfCircle);
        Debug.Log("���� ������: " + sizeOfCircle + ", ���� ������: " + radius);
    }

    // ����Ƽ���� �ַ� float ���
    float GetRadius(float size)
    {
        float pi = 3.14f;

        float tmp = size/pi;

        // Mathf : UnityEngine ���ӽ����̽��� ������ ����
        float radius = Mathf.Sqrt(tmp);

        return radius;
    }
}
