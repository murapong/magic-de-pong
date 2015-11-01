using UnityEngine;
using System.Collections;

public class Damage
{
    public static int Get(int rare, SkillData.Element offender, SkillData.Element defender)
    {
        float buf = 1.0f;
        if (IsStrong(offender, defender))
        {
            buf = ConfigData.StringElementDamage;
        }
        else if (IsWeak(offender, defender))
        {
            buf = ConfigData.WeakElementDamage;
        }
        switch(rare)
        {
            case 1:
                return (int)(buf * ConfigData.Rare1Damage);
            case 2:
                return (int)(buf * ConfigData.Rare2Damage);
            case 3:
                return (int)(buf * ConfigData.Rare3Damage);
            case 4:
                return (int)(buf * ConfigData.Rare4Damage);
            default:
                Debug.LogError("unexpected rare " + rare);
                return 0;
        }
    }
    private static bool IsStrong(SkillData.Element offender, SkillData.Element defender)
    {
        switch(offender)
        {
            case SkillData.Element.Fire:
                return defender == SkillData.Element.Wind;
            case SkillData.Element.Water:
                return defender == SkillData.Element.Fire;
            case SkillData.Element.Wind:
                return defender == SkillData.Element.Water;
        }
        return false;
    }
    private static bool IsWeak(SkillData.Element offender, SkillData.Element defender)
    {
        switch(offender)
        {
            case SkillData.Element.Fire:
                return defender == SkillData.Element.Water;
            case SkillData.Element.Water:
                return defender == SkillData.Element.Wind;
            case SkillData.Element.Wind:
                return defender == SkillData.Element.Fire;
        }
        return false;
    }
}
