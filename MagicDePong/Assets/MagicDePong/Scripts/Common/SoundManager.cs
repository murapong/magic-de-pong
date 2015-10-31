using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
	#region enum

	#endregion

	#region const

	#endregion

	#region public property

	public static SoundManager Instance;

	#endregion

	#region private property

	#region AudioClip

	/// <summary>
	/// 決定音。
	/// </summary>
	[SerializeField]
	AudioClip audioClipYesSE;

	/// <summary>
	/// ゲームオーバーSE。
	/// </summary>
	[SerializeField]
	AudioClip audioClipGameOverSE;

	#endregion

	#region AudioSource

	AudioSource audioSourceYes;

	AudioSource audioSourceGameOver;

	#endregion

	#endregion

	#region public method

	/// <summary>
	/// 決定音を再生する。
	/// </summary>
	public void PlayYesSE ()
	{
		audioSourceYes.Play ();
	}

	/// <summary>
	/// ゲームオーバーSEを再生する。
	/// </summary>
	public void PlayGameOverSE ()
	{
		audioSourceGameOver.Play ();
	}

	#endregion

	#region private method

	#endregion

	#region event

	void Awake ()
	{
		Instance = this;

		InitSound ();
	}

	/// <summary>
	/// サウンドの初期化を行う。
	/// </summary>
	void InitSound ()
	{
		audioSourceYes = gameObject.AddComponent<AudioSource> ();
		audioSourceYes.clip = audioClipYesSE;
		audioSourceYes.loop = false;

		audioSourceGameOver = gameObject.AddComponent<AudioSource> ();
		audioSourceGameOver.clip = audioClipGameOverSE;
		audioSourceGameOver.loop = false;
	}

	#endregion
}
