using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_Her_tıklamada_random_tek_cift_sayi : MonoBehaviour
{
    int sayi;
    bool ciftSayiMi;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            sayi = Random.Range(1, 100);


        if (sayi % 2 == 0)
            ciftSayiMi = true;
        else
            ciftSayiMi = false;

        Debug.Log("sayi : " + sayi + " kontrol : " + ciftSayiMi);

    }
}
