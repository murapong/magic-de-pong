using UnityEngine;
using System.Collections;

public class EffectManager : MonoBehaviour
{
    [SerializeField]
    private SkillIcon icon;
	public static EffectManager Instance;

	void Awake() {
		Instance = this;
	}
	public void Show(SkillData data)
	{
       GameObject effect = (GameObject)Resources.Load("effect/prefab/" + data.effectName);
       if (effect == null)
       {
            Debug.LogError("effect name is bad: " + data.effectName);
            return;
       }
       GameObject obj = Instantiate(effect, transform.position + new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
       obj.transform.transform.Rotate(data.rotationX, 0, 0);
       obj.transform.position = new Vector3(data.positionRight, data.positionUp, obj.transform.position.z - data.positionFront);
	   obj.transform.SetParent(transform);
	   obj.AddComponent<Effect>().SetAliveTime(data.aliveTime);
       if (data.skillIconId != 0)
       {
           icon.Show(data.skillIconId, data.skillIconWidth, data.skillIconHeight);
       }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
