using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class OfflineGameService
{

	[Inject] private GameController _Controller;
	[Inject] private GameState _State;


}
