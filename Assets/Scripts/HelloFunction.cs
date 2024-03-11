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
        Debug.Log("원의 사이즈: " + sizeOfCircle + ", 원의 반지름: " + radius);
    }

    // 유니티에선 주로 float 사용
    float GetRadius(float size)
    {
        float pi = 3.14f;

        float tmp = size/pi;

        // Mathf : UnityEngine 네임스페이스가 가지고 있음
        float radius = Mathf.Sqrt(tmp);

        return radius;
    }
}
