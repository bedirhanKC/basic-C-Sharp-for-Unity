using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders4_ifElse : MonoBehaviour
{

    int sayi;

    private void Start()
    {
        sayi = Random.Range(-3, 4);

        if (sayi < 0)
        {

            Debug.Log("sayi negatiftir. ve " + sayi + "'dir");

        }
        else if (sayi > 0)
        {

            Debug.Log("sayi pozitiftir. ve " + sayi + "'dir");

        }
        else
        {

            Debug.Log("sayi 0'a esittir ve " + sayi + "'dir");

        }

    }

}
