using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public delegate void InputEventHandler();

public class InputManager : MonoBehaviour {
    public event InputEventHandler onResetEvent;
    [SerializeField]
    private Canvas canvas;

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
       isStartInput = false;
       numberList = new List<int>();
	}
    public void OnChoiced(int i, int j)
    {
        numberList.Add(j * 10 + i);
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
        if (Input.GetMouseButtonUp(0))
        {
            OnEnd();
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
