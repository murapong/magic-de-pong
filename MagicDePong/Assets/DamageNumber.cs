using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DamageNumber : MonoBehaviour {
    [SerializeField]
    private Text text;
    [SerializeField]
    private Text textBg;
	void Start () {
        text.gameObject.SetActive(false);
        textBg.gameObject.SetActive(false);
	}
    public void Set(int damage, Damage.Type type)
    {
        SetAllActive(true);
        text.text = damage.ToString();
        textBg.text = damage.ToString();
        Hashtable table = new Hashtable();
        float scale = GetScale(type);
        gameObject.transform.localScale = new Vector3(scale, scale, scale);
        text.color = GetColor(type);
        // table.Add("x", scale);
        // table.Add("y", scale);
        table.Add("time", 1.0f);
        table.Add("oncomplete", "CompleteHandler");
        iTween.ScaleTo(gameObject, table);
    }
    private float GetScale(Damage.Type type)
    {
        switch(type)
        {
            case Damage.Type.Strong:
                return 1.5f;
            case Damage.Type.Weak:
                return 0.3f;
            case Damage.Type.Normal:
                return 1.0f;
        }
        return 1.0f;
    }
    private void CompleteHandler()
    {
        SetAllActive(false);
    }
    private void SetAllActive(bool isActive)
    {
        text.gameObject.SetActive(isActive);
        textBg.gameObject.SetActive(isActive);
    }
    private Color GetColor(Damage.Type type)
    {
        switch(type)
        {
            case Damage.Type.Strong:
                return Color.yellow;
            case Damage.Type.Weak:
                return Color.blue;
            case Damage.Type.Normal:
                return Color.black;
        }
        return Color.black;
    }
	
	void Update () {
	
	}
}
