﻿using Dxx.Util;
using System;
using UnityEngine;

public class Weapon5115 : WeaponBase
{
    protected override void OnAttack(object[] args)
    {
        int count = 3;
        for (int i = 0; i < count; i++)
        {
            base.CreateBulletOverride(Vector3.zero, Utils.GetBulletAngle(i, count, 90f));
        }
    }

    protected override void OnInstall()
    {
    }

    protected override void OnUnInstall()
    {
    }
}

