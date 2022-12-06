using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_Her_Tıklamada_Sayac_Arttırma : MonoBehaviour
{

    int sayac;

    private void Start()
    {

        sayac = 0;

    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            sayac++;

        }
        else if (Input.GetMouseButtonDown(1))
        {

            sayac--;

        }

        Debug.Log("sayac degeri : " + sayac);

    }

}
