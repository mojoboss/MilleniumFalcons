using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class OfflineGameService
{

	[Inject] private GameController _Controller;
	[Inject] private GameState _State;

	public void SetupGame()
	{
		_State.SetMyPlayerId(0);
	}

	public void MoveOnKeyPress(C.KeyType type)
	{
		SetupGame();
		int _myPlayerId = _State.GetMyPlayerId();
		if (type == C.KeyType.LEFT_KEY)
		{
			_State.SetPlayerVelocityX(_myPlayerId, -1);
			float velX = _State.GetPlayerVel(_myPlayerId);
		}
	}
}
