using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders_10_list : MonoBehaviour
{

    List<int> rakamlar = new List<int>();

    // Start is called before the first frame update
    void Start()
    {

        rakamlar.Add(0);
        rakamlar.Add(1);
        rakamlar.Add(2);
        rakamlar.Add(4);
        rakamlar.Remove(4); // datasi 4 olan düðümü siler
        //rakamlar.RemoveAt(2); indeksi 2 olan düðümü siler

        Debug.Log("listinin eleman sayisi : " + rakamlar.Count); // .count listenin eleman sayisini gosterir.

        foreach(int rakam in rakamlar)
        {

            Debug.Log(rakam);

        }

        
    }
}
