using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
    private const int NUM_WIDTH = 5;
    private const int NUM_HEIGHT = 5;
    private Vector3 basePosition;
    GameObject prefab;
    private bool isStartInput;
    public bool IsStartInput() { return isStartInput;}
	void Start () {
	   prefab = (GameObject)Resources.Load ("Prefabs/Input/InputButton");
       basePosition =  new Vector3(32, 30, 0);
       for (int i = 0; i < NUM_WIDTH; i++)
       {
            for (int j = 0; j < NUM_HEIGHT; j++)
            {
                Vector3 pos = GetButtonPosition(i, j);
                GameObject obj = Instantiate(prefab, pos, Quaternion.identity) as GameObject;
                obj.transform.SetParent(transform);
                obj.GetComponent<InputButton>().Initialize(i, j, this);
            }
       }
       isStartInput = false;

	}
    public void OnChoiced(int i, int j)
    {
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
    }
    private Vector3 GetButtonPosition(int i, int j)
    {
        return basePosition + new Vector3(i * (InputButton.SIZE_WIDTH - InputButton.SIZE_GAP),
            j * (InputButton.SIZE_HEIGHT - InputButton.SIZE_GAP), 0);
    }
}
