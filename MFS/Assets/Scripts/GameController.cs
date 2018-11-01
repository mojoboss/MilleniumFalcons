using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class GameController: IInitializable
{

    [Inject] private OfflineGameService _service;
    [Inject] private GameExperienceEngine _experienceEngine;


    public void Initialize()
    {
        Debug.Log("Game controller initialize called");
        Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.LeftArrow))
            .Subscribe(_ =>
            {
                Debug.Log("Left Arrow Button Pressed");
            });

        Observable.EveryUpdate().Where(_ => Input.GetKeyDown(KeyCode.RightArrow))
            .Subscribe(_ =>
            {
                Debug.Log("Right Arrow Button Pressed");
            });
    }
}
