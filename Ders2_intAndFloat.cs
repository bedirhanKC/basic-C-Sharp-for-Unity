using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders2_intAndFloat : MonoBehaviour
{

    int a = 5;
    int b = 10;
    float A = 15.5f;

    private void Start()
    {
        Debug.Log(a);
        Debug.Log(b);
        Debug.Log(a + b);
        Debug.Log("----------");
        Debug.Log(a);
        Debug.Log(A);
        Debug.Log(A + a);
    }

}
