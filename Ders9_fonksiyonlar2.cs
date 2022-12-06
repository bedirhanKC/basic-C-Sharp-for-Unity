using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders9_fonksiyonlar2 : MonoBehaviour
{

    int toplam;

    private void Start()
    {

        toplam = ikiSayininToplami(5, 11);
        Debug.Log(toplam);

    }

    int ikiSayininToplami(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

}
