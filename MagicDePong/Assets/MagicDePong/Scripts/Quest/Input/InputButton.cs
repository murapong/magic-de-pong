using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputButton : Button, ICanvasRaycastFilter, IPointerEnterHandler, IDragHandler{
    public const int SIZE_RADIUS = 80;
    public const int SIZE_GAP = 20;//画像自体のサイズと円の部分との隙間


    private RectTransform rectTransform;
    private Image image;
    private bool isTapped;
    private int i;
    private int j;
    private InputManager inputManager;
    private float scale;

    public void Start()
    {
        image = GetComponent<Image>();
        Reset();
    }
    public void Initialize(int i, int j, InputManager manager, float scale)
    {
        this.i = i;
        this.j = j;
        this.inputManager = manager;
        manager.onResetEvent += Reset;
        name = "button_" + i.ToString() + "_" + j.ToString();
        this.scale = scale;
        rectTransform = GetComponent (typeof (RectTransform)) as RectTransform;
        rectTransform.sizeDelta = new Vector2(SIZE_RADIUS * 2, SIZE_RADIUS * 2) * scale;
    }
    public void Reset()
    {
        image.color = Color.white;
        isTapped = false;
        UpdateColor();
    }
    public bool IsRaycastLocationValid (Vector2 sp, Camera eventCamera)
    {
        return Vector2.Distance(sp, transform.position) < SIZE_RADIUS * scale;
    }
    public void OnDrag(PointerEventData eventData)
    {
        OnMove();
    }
    public void OnPointerEnter(PointerEventData ped)
    {
        OnMove();
    }
    private void OnMove()
    {
        if (inputManager.IsStartInput() && !isTapped)
        {
            image.color = Color.black;
            isTapped = true;
            inputManager.OnChoiced(i, j);
            UpdateColor();
        }
    }
    private void UpdateColor()
    {
        if (!ConfigData.ShowMagicButton)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, 0);
        }
    }
}