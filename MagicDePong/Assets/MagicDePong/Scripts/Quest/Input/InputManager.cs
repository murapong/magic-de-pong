using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {
    private const int NUM_WIDTH = 5;
    private const int NUM_HEIGHT = 5;
    private Vector3 basePosition;
    GameObject prefab;
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
                obj.name = "button_" + i.ToString() + "_" + j.ToString();
            }
       }
	}

	void Update ()
    {
	}
    private Vector3 GetButtonPosition(int i, int j)
    {
        return basePosition + new Vector3(i * (InputButton.SIZE_WIDTH - InputButton.SIZE_GAP),
            j * (InputButton.SIZE_HEIGHT - InputButton.SIZE_GAP), 0);
    }
}
