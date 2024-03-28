using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IWeapon
{
    public void Attack()
    {
        Debug.Log("[Bullet] Attack to Target!");
    }

    public void Attack(GameObject obj)
    {
        Vector3 v3 = new Vector3(transform.position.x, transform.position.y, 0);

        var Bullet = Instantiate(obj);

        Bullet.transform.position = v3;

    }
}
