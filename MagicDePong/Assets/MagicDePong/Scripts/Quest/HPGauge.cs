using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPGauge : MonoBehaviour {
    [SerializeField]
    private Slider slider;
    public void SetPercent(float percent)
    {
        slider.value = percent;
    }
}
