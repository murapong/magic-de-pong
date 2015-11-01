using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public delegate void InputEventHandler();

public class InputManager : MonoBehaviour {
    public event InputEventHandler onResetEvent;
    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private GameObject trail;
    [SerializeField]
    private Camera trailRendererCamera;


    private const int NUM_WIDTH = 5;
    private const int NUM_HEIGHT = 5;
    private Vector3 basePosition;
    GameObject prefab;
    private bool isStartInput;
    public bool IsStartInput() { return isStartInput;}
    private List<int> numberList;
	void Start () {
	   prefab = (GameObject)Resources.Load("Prefabs/Input/InputButton");
       basePosition =  new Vector3(74, 70, 0);
       for (int i = 0; i < NUM_WIDTH; i++)
       {
            for (int j = 0; j < NUM_HEIGHT; j++)
            {
                Vector3 pos = GetButtonPosition(i, j);
                GameObject obj = Instantiate(prefab, pos, Quaternion.identity) as GameObject;
                obj.transform.SetParent(transform);
                obj.GetComponent<InputButton>().Initialize(i, j, this, canvas.scaleFactor);
            }
       }
       trailRendererCamera.orthographicSize = canvas.scaleFactor * canvas.GetComponent<RectTransform>().sizeDelta.x * 0.9f;
       isStartInput = false;
       numberList = new List<int>();
       GameManager.Instance().inputManager = this;
	}
    public void OnChoiced(int i, int j)
    {
        numberList.Add(j * 10 + i);
    }
    public void SetElement(SkillData.Element type)
    {
        gameObject.SetActive(false);
    }
    public void OpenLock()
    {
        gameObject.SetActive(true);
    }
	void Update ()
    {
        UpdateMouse();
        UpdateTouch();
	}
    private void UpdateMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isStartInput = true;
        }
        if (isStartInput && Input.GetMouseButton(0))
        {
            trail.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            OnEnd();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameManager.Instance().AttackDebug(0);
        }
    }
    private void UpdateTouch()
    {
        foreach (Touch touch in Input.touches) {
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    isStartInput = true;
                    break;
                case TouchPhase.Ended:
                    OnEnd();
                    break;
                case TouchPhase.Moved:
                    trail.transform.position = new Vector3(touch.position.x, touch.position.y, 0);
                    break;
            }
        }
    }
    private void OnEnd()
    {
        GameManager.Instance().OnInputEnd(numberList);
        Reset();
    }
    private void Reset()
    {
        isStartInput = false;
        onResetEvent();
        numberList.Clear();
    }
    private Vector3 GetButtonPosition(int i, int j)
    {
        float scale = canvas.scaleFactor;
        return (basePosition + new Vector3(i * (InputButton.SIZE_RADIUS * 2- InputButton.SIZE_GAP),
            j * (InputButton.SIZE_RADIUS * 2 - InputButton.SIZE_GAP), 0)) * scale;
    }
}
