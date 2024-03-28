using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ������ ���� ���� enum
public enum WeaponType
{
    Bullet, Sword, Arrow
}

public class WeaponManager : MonoBehaviour
{
    // ������ ����
    public GameObject _bullet;
    public GameObject _sword;
    public GameObject _arrow;

    // ������ ����
    private GameObject selected_weapon;

    //���� ���� ��� Ŭ������ �ʵ� ������ �����ϴ�.
    WeaponSelector weaponSelector;

    private IWeapon iwp;    // ���⿡ ���� ���� ����

    private void Start()
    {
        // weaponSelector = new WeaponSelector();
        //���� ���� Ŭ������ ����� ���� �������̽��� ������ Ŭ������
        //Ȱ���մϴ�.
        // weaponSelector.SetWeapon(new Bullet());

        ChangeWeapon(WeaponType.Bullet);
    }

    private void ChangeWeapon(WeaponType weaponType)
    {
        // ������Ʈ�� �پ��ִ� IWeapon ���� ������Ʈ�� ������ �� ���� �ı��մϴ�.
        // c.g) Bullet -> Sword �� ������ �ǵ� Bullet�� ������Ʈ�� ���������� �ȵǱ� ����
        var c = gameObject.GetComponent<IWeapon>() as Component;

        if (c != null)
        {
            Destroy(c);
        }

        // ���� ������ ���� ó��
        switch (weaponType)
        {
            case WeaponType.Bullet:
                iwp = gameObject.AddComponent<Bullet>();    // �������� �Ѿ˷� ����
                selected_weapon = _bullet;  // �ش� ���⸦ ����
                break;
            case WeaponType.Sword:
                iwp = gameObject.AddComponent<Sword>();
                selected_weapon = _sword;
                break;
            case WeaponType.Arrow:
                iwp = gameObject.AddComponent<Arrow>();
                selected_weapon = _arrow;
                break;
            // �⺻ �� = ���� enum�� ù��° ��
            default:
                iwp = gameObject.AddComponent<Bullet>();
                selected_weapon = _bullet;
                break;
        }

    }


    //���� ���� Ŭ������ ��ɵ��� ���� �������̽��� ������ Ŭ������ ���� ������ �����մϴ�.
    public void ChangeBullet() => ChangeWeapon(WeaponType.Bullet);
    public void ChangeSword() => ChangeWeapon(WeaponType.Sword);
    public void ChangeArrow() => ChangeWeapon(WeaponType.Arrow);

    public void OnFire() => iwp.Attack(selected_weapon);
}
