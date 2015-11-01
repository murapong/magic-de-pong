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
            case 0:  return new EnemyData(  50, SkillData.Element.Fire);
            case 1:  return new EnemyData(  100, SkillData.Element.Water);
            case 2:  return new EnemyData(  100, SkillData.Element.Water);
            case 3:  return new EnemyData(  150, SkillData.Element.Wind);
            case 4:  return new EnemyData(  500, SkillData.Element.Fire);//???
            case 5:  return new EnemyData(  150, SkillData.Element.Wind);
            case 6:  return new EnemyData(  200, SkillData.Element.Fire);
            case 7:  return new EnemyData(  200, SkillData.Element.Fire);//???
            case 8:  return new EnemyData(  250, SkillData.Element.Fire);
            case 9:  return new EnemyData(  750, SkillData.Element.Water);//???
            case 10: return new EnemyData(  250, SkillData.Element.Water);//???
            case 11: return new EnemyData(  300, SkillData.Element.Fire);//???
            case 12: return new EnemyData(  300, SkillData.Element.Wind);
            case 13: return new EnemyData(  350, SkillData.Element.Water);
            case 14: return new EnemyData(  1000, SkillData.Element.Wind);
            case 15: return new EnemyData(  350, SkillData.Element.Fire);
            case 16: return new EnemyData(  400, SkillData.Element.Wind);
            case 17: return new EnemyData(  400, SkillData.Element.Water);
            case 18: return new EnemyData(  450, SkillData.Element.Fire);
            case 19: return new EnemyData(  2250, SkillData.Element.Normal);
        }
        return null;
    }

    private EnemyData(int hp, SkillData.Element element)
    {
        this.hp = hp;
        this.element = element;
    }
}
