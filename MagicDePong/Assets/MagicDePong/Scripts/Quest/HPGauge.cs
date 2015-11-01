using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPGauge : MonoBehaviour {
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private GameObject fillArea;
    public void SetElement(SkillData.Element type)
    {
        fillArea.GetComponentInChildren<Image>().color = GetColor(type);
    }
    private Color GetColor(SkillData.Element type)
    {
        switch(type)
        {
            case SkillData.Element.Fire:
                return Color.red;
            case SkillData.Element.Water: 
                return Color.blue;
            case SkillData.Element.Wind:
                return Color.green;
        }
                return Color.red;
    }
    public void SetPercent(float percent)
    {
        slider.value = percent;
        fillArea.SetActive(percent > 0);
    }
}
