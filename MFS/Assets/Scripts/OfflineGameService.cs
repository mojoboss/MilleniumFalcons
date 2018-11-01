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
		_State.SetPlayerVelocityX(0, 0);
		_State.SetPlayerPositionX(0, -3);

		_State.SetPlayerVelocityX(1, 0);
		_State.SetPlayerPositionX(1, -1);

		_State.SetPlayerVelocityX(2, 0);
		_State.SetPlayerPositionX(2, 1);

		_State.SetPlayerVelocityX(3, 0);
		_State.SetPlayerPositionX(3, 3);
	}

	public void MoveOnKeyPress(C.KeyType type)
	{
		int _myPlayerId = _State.GetMyPlayerId();
		if (type == C.KeyType.LEFT_KEY)
		{
			_State.SetPlayerVelocityX(_myPlayerId, -1);
			float velX = _State.GetPlayerVel(_myPlayerId);
			//TODO: set the position here
		}
	}
}
