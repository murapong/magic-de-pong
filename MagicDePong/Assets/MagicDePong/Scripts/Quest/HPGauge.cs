using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPGauge : MonoBehaviour {
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private GameObject fillArea;
    public void SetPercent(float percent)
    {
        slider.value = percent;
        fillArea.SetActive(percent > 0);
    }
}
