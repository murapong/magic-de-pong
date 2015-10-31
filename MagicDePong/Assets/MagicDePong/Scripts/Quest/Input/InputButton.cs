using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputButton : Button, ICanvasRaycastFilter, IPointerEnterHandler {
    public const int SIZE_WIDTH = 82;
    public const int SIZE_HEIGHT = 82;
    public const int SIZE_GAP = 15;//画像自体のサイズと円の部分との隙間
    private RectTransform rectTransform;
    private Image image;

    public void Start()
    {
        rectTransform = GetComponent (typeof (RectTransform)) as RectTransform;
        rectTransform.sizeDelta = new Vector2(SIZE_WIDTH, SIZE_WIDTH);
        image = GetComponent<Image>();
    }
    public bool IsRaycastLocationValid (Vector2 sp, Camera eventCamera)
    {
        return Vector2.Distance(sp, transform.position) < rectTransform.sizeDelta.x;
    }
    public void OnPointerEnter(PointerEventData ped)
    {
        image.color = Color.black;
    }
}