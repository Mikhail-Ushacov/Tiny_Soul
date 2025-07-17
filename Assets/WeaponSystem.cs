using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public enum WeaponType { Scythe, Sword, Whip, Hook }
    public WeaponType currentWeapon = WeaponType.Scythe;

    void Update()
    {
        HandleWeaponSwitch();
        HandleAttack();
    }

    void HandleWeaponSwitch()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            currentWeapon = WeaponType.Scythe;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            currentWeapon = WeaponType.Sword;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            currentWeapon = WeaponType.Whip;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            currentWeapon = WeaponType.Hook;
    }

    void HandleAttack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (currentWeapon)
            {
                case WeaponType.Scythe:
                    Debug.Log("Атака КОСОЙ!");
                    break;
                case WeaponType.Sword:
                    Debug.Log("Атака МЕЧОМ!");
                    break;
                case WeaponType.Whip:
                    Debug.Log("УДАР КНУТОМ!");
                    break;
                case WeaponType.Hook:
                    Debug.Log("Бросок КРЮКА!");
                    break;
            }
        }
    }
}
