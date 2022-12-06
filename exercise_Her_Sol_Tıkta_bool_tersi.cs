using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise_Her_Sol_Tıkta_bool_tersi : MonoBehaviour
{
    bool solTik;

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            solTik = !solTik;
            Debug.Log(solTik);

        }


    }
}
