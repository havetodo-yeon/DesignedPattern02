using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector 
{

    //�������̽� ����(������)
    private IWeapon iwp;


    //���⿡ ���� ��ü
    public void SetWeapon(IWeapon weapon)
    {
        iwp = weapon;   
    }

    //���� ���
    public void Attack()
    {
        iwp.Attack();
    }
}
