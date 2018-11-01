using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public static class C
{
	public enum KeyType
	{
		LEFT_KEY,
		RIGHT_KEY
	}

	public static Dictionary<KeyCode, KeyType> KeyMapping = new Dictionary<KeyCode, KeyType>()
	{
		{KeyCode.LeftArrow, KeyType.LEFT_KEY}
		,{KeyCode.RightArrow, KeyType.RIGHT_KEY}
	};
}


public class GameExperienceEngine : MonoBehaviour
{

	[Inject] private GameSceneViewModel _ViewModel;

	public void HandleMovement(KeyCode key, Action<C.KeyType> onComplete)
	{
		//TODO: Do something later
		onComplete(C.KeyMapping[key]);

	}

}
