using UnityEngine;

public abstract class Panel : MonoBehaviour, IRefresh
{
    [SerializeField, ReadOnly] private bool isOpen;

    public bool IsOpen => isOpen;

    public void Open()
    {
        if (IsOpen)
        {
            Debug.LogError($"{gameObject.name} is already open");
            return;
        }

        isOpen = false;
        gameObject.SetActive(isOpen);
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
    }

    public abstract void Initialize();

    public abstract void Refresh();

    public virtual bool CanOpen() => true;
}
