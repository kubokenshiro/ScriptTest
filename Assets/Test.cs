using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);

        for(int i = 0; i <= 10; i++)
        {
        lastboss.Magic(5);
        }
    }
}
