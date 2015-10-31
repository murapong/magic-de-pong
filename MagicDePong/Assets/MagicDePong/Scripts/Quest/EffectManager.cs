using UnityEngine;
using System.Collections;

public class EffectManager : MonoBehaviour
{
	public static EffectManager Instance;

	void Awake() {
		Instance = this;
	}
	public void Show(SkillData data)
	{
       GameObject effect = (GameObject)Resources.Load("effect/prefab/" + data.effectName);
       GameObject obj = Instantiate(effect, transform.position + new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
       obj.transform.transform.Rotate(data.rotationX, 0, 0);
	   obj.transform.SetParent(transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
