using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
    int[] array = {1, 2, 3, 4, 5};
    // array.ForEachReverse( i => Debug.Log(i));

    for(int i = 0; i < array.Length; i++)
    {
        Debug.Log(array[i]);
    }
        
    }
   
}
