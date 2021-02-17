using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Magic(int magic)
    {
        this.mp -= magic;
        if(mp >= 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else if(mp <= 0)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
}
