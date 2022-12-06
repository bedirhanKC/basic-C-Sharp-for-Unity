using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ders6_whileVeForDöngüsü : MonoBehaviour
{

    int i;

    private void Start()
    {
        
        while(i < 10)
        {
            i++;
            Debug.Log(i);
            

        }

        Debug.Log("------------");

        for(i=0; i < 10; i += 2)
        {

            Debug.Log(i);

        }

    }

}
