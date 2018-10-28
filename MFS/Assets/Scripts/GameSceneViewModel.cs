using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS;
using UnityEngine;
using Zenject;

public class GameSceneViewModel : MonoBehaviour
{
	[Inject(Id = "FalconShip0")] public Transform _FalconShip0;

	[Inject(Id = "FalconShip1")] public Transform _FalconShip1;

	[Inject(Id = "FalconShip2")] public Transform _FalconShip2;

	[Inject(Id = "FalconShip3")] public Transform _FalconShip3;
}
