using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState {

	public class ShipState
	{
		private float posx;
		private float posy;
		private float vely;
		private float velx;

		public float GetVelocityX()
		{
			return velx;
		}
		public float GetPosX()
		{
			return posx;
		}
		public void SetVelocityX(float velX)
		{
			velx = velX;
		}
		public void SetPosX(float posX)
		{
			posx = posX;
		}
	}

	private int _MyPlayerId;
	private Dictionary<int, ShipState> GameShipStates = new Dictionary<int, ShipState>();

	public void SetMyPlayerId(int id)
	{
		_MyPlayerId = id;
	}

	public int GetMyPlayerId()
	{
		return _MyPlayerId;
	}

	public void SetPlayerPositionX(int playerId, float posx)
	{
		GameShipStates[playerId].SetPosX(posx);
	}

	public void SetPlayerVelocityX(int playerId, float velx)
	{
		GameShipStates[playerId].SetVelocityX(velx);
	}

	public float GetPlayerPos(int playerId)
	{
		return GameShipStates[playerId].GetPosX();
	}

	public float GetPlayerVel(int playerId)
	{
		return GameShipStates[playerId].GetVelocityX();
	}
}
