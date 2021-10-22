using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    PlayerInput input;
    [SerializeField]
    Weapon leftWeapon;
    [SerializeField]
    Weapon rightWeapon;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetLeftShoot())
            leftWeapon.Trigger();

        if (input.GetRightShoot())
            rightWeapon.Trigger();
    }
}






































/*
PlayerInput input;
    [SerializeField]
    Weapon leftWeapon;
    [SerializeField]
    Weapon rightWeapon;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetLeftShoot())
            leftWeapon.Trigger();

        if (input.GetRightShoot())
            rightWeapon.Trigger();
    }
*/