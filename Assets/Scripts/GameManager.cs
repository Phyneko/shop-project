using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [field: SerializeField] public UIManager UiManager { get; private set; }
    
    public CustomUpdater CustomUpdater { get; private set; }

    public void Awake()
    {
        CustomUpdater = new CustomUpdater();

        UiManager.Initialize();
    }

    public void Update()
    {
        CustomUpdater.Refresh();
        UiManager.Refresh();
    }
}
