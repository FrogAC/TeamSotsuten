﻿///-------------------------------------------------------------------------
///
/// code by miyake yuji
///
/// エフェクトの作成管理スクリプト
/// 
///-------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

public class EffectCreate : MonoBehaviour
{
    [SerializeField]
    CheckActive strength;

    [SerializeField]
    CheckActive Weak;

    [SerializeField]
    GameObject player;

    /// <summary>
    /// どの攻撃タイプのエフェクトを生成するか確認
    /// </summary>
    /// <param name="skillType"></param>
    void CheckType(MotionManager.MotionSkillType skillType)
    {
        GameObject checkObject = null;

        switch (skillType)
        {
            case MotionManager.MotionSkillType.STRENGTH:
                strength.Check(skillType , player);
                checkObject = strength.gameObject;
                break;
            case MotionManager.MotionSkillType.WEAK:
                Weak.Check(skillType,player);
                checkObject = Weak.gameObject;
                break;
            default:
                break;
        }
    }
}
