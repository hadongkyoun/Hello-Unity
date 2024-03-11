using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] scores = new int[10];
        
        for(int i = 1; i <=10; i++)
        {
            scores[i - 1] = i;
        }
        
        for(int i = 0; i<10; i++)
        {
            Debug.Log(scores[i]);
        }
        
    }

}
