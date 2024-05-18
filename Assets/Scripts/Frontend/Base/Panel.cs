using System;
using UnityEngine;

public abstract class Panel : MonoBehaviour, IRefresh
{
    [SerializeField, ReadOnly] private bool isOpen;

    public bool IsOpen => isOpen;

    public event Action OnOpen;
    public event Action OnClose;

    public void Open()
    {
        if (IsOpen)
        {
            Debug.LogError($"{gameObject.name} is already open");
            return;
        }

        isOpen = false;
        gameObject.SetActive(isOpen);
        OnOpen?.Invoke();
    }

    public void Close()
    {
        if(!IsOpen)
        {
            Debug.LogError($"{gameObject.name} is already closed");
            return;
        }

        isOpen = false;
        gameObject.SetActive(isOpen);

        OnClose.Invoke();
    }

    public virtual void Initialize() { }

    public virtual void Refresh() { }

    public virtual bool CanOpen() => true;

    public virtual bool CanClose() => true;
}
