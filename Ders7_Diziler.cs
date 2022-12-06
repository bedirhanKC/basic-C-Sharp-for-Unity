using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders7_Diziler : MonoBehaviour
{

    int[] dogalSayilar = new int[10];
    string[] isimler = { "bedirhan", "ufuk", "mehmet", "hasan" };



    private void Start()
    {

        for (int i = 0; i < 10; i++)
        {

            dogalSayilar[i] = i;
            Debug.Log(dogalSayilar[i]);

        }

        Debug.Log("-----------");

        for(int i=0; i<isimler.Length; i++)
        {

            Debug.Log(isimler[i]);

        }
    }


}
