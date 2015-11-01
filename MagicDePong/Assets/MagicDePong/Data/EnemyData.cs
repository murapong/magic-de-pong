using UnityEngine;
using System.Collections;

public class EnemyData
{
    public int hp;
    public SkillData.Element element;

    public static EnemyData Get(int id)
    {
        switch(id)
        {
            case 0:  return new EnemyData(  10, SkillData.Element.Fire);
            case 1:  return new EnemyData(  10, SkillData.Element.Fire);
            case 2:  return new EnemyData(  10, SkillData.Element.Fire);
            case 3:  return new EnemyData(  10, SkillData.Element.Fire);
            case 4:  return new EnemyData(  10, SkillData.Element.Fire);
            case 5:  return new EnemyData(  10, SkillData.Element.Fire);
            case 6:  return new EnemyData(  10, SkillData.Element.Fire);
            case 7:  return new EnemyData(  10, SkillData.Element.Fire);
            case 8:  return new EnemyData(  10, SkillData.Element.Fire);
            case 9:  return new EnemyData(  10, SkillData.Element.Fire);
            case 10: return new EnemyData(  10, SkillData.Element.Fire);
            case 11: return new EnemyData(  10, SkillData.Element.Fire);
            case 12: return new EnemyData(  10, SkillData.Element.Fire);
            case 13: return new EnemyData(  10, SkillData.Element.Fire);
            case 14: return new EnemyData(  10, SkillData.Element.Fire);
            case 15: return new EnemyData(  10, SkillData.Element.Fire);
        }
        return null;
    }

    private EnemyData(int hp, SkillData.Element element)
    {
        this.hp = hp;
        this.element = element;
    }
}
