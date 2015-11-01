using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HP : MonoBehaviour {
    [SerializeField]
    private Slider slider;
    private float point = 1.0f;
    public void SetPercent(float percent)
    {
        slider.value = percent;
    }
	
	void Update () {
	   point*= 0.95f;
       SetPercent(point);
	}
}
