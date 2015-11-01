using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SkillIcon : MonoBehaviour {
    private Image image;
    private Vector3 startPosition;
    private float time;
	void Start () {
        image = GetComponent<Image>();
        image.enabled = false;
        startPosition = transform.position;
	}

    public void Show(int skillId, int width, int height)
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(width, height);
        image.enabled = true;
        transform.position = startPosition;
        time = 0.8f;
    }	
	void Update () {
        if (!image.enabled || time <= 0)
            return;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Hashtable table = new Hashtable();  
            table.Add("x", - 500.1f);
            table.Add("time", 0.5f);
            table.Add("oncomplete", "CompleteHandler");
            iTween.MoveBy(gameObject, table);
        }
	}
    private void CompleteHandler()
    {
        image.enabled = false;
    }
}
