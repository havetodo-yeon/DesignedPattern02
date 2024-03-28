using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 무기의 유형을 고르기 위한 enum
public enum WeaponType
{
    Bullet, Sword, Arrow
}

public class WeaponManager : MonoBehaviour
{
    // 무기의 종류
    public GameObject _bullet;
    public GameObject _sword;
    public GameObject _arrow;

    // 선택한 무기
    private GameObject selected_weapon;

    //무기 선택 기능 클래스를 필드 값으로 가집니다.
    WeaponSelector weaponSelector;

    private IWeapon iwp;    // 무기에 대한 접근 지점

    private void Start()
    {
        // weaponSelector = new WeaponSelector();
        //무기 선택 클래스의 기능을 통해 인터페이스로 구현한 클래스를
        //활용합니다.
        // weaponSelector.SetWeapon(new Bullet());

        ChangeWeapon(WeaponType.Bullet);
    }

    private void ChangeWeapon(WeaponType weaponType)
    {
        // 오브젝트에 붙어있는 IWeapon 관련 컴포넌트를 조사해 그 값을 파괴합니다.
        // c.g) Bullet -> Sword 로 변경할 건데 Bullet의 컴포넌트가 남아있으면 안되기 때문
        var c = gameObject.GetComponent<IWeapon>() as Component;

        if (c != null)
        {
            Destroy(c);
        }

        // 무기 유형에 따라 처리
        switch (weaponType)
        {
            case WeaponType.Bullet:
                iwp = gameObject.AddComponent<Bullet>();    // 접근점을 총알로 변경
                selected_weapon = _bullet;  // 해당 무기를 선택
                break;
            case WeaponType.Sword:
                iwp = gameObject.AddComponent<Sword>();
                selected_weapon = _sword;
                break;
            case WeaponType.Arrow:
                iwp = gameObject.AddComponent<Arrow>();
                selected_weapon = _arrow;
                break;
            // 기본 값 = 보통 enum의 첫번째 값
            default:
                iwp = gameObject.AddComponent<Bullet>();
                selected_weapon = _bullet;
                break;
        }

    }


    //무기 선택 클래스의 기능들을 통해 인터페이스로 구현한 클래스에 대한 설정을 변경합니다.
    public void ChangeBullet() => ChangeWeapon(WeaponType.Bullet);
    public void ChangeSword() => ChangeWeapon(WeaponType.Sword);
    public void ChangeArrow() => ChangeWeapon(WeaponType.Arrow);

    public void OnFire() => iwp.Attack(selected_weapon);
}
