using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour, IRefresh
{
    [SerializeField] private UIConfig config;

    [field: SerializeField, ReadOnly] public ShopPanel ShopPanel { get; private set; }
    [field: SerializeField, ReadOnly] public InventoryPanel InventoryPanel { get; private set; }
    [field: SerializeField, ReadOnly] public PausePanel PausePanel { get; private set; }

    private List<Panel> openPanels;

    public void Initialize()
    {
        openPanels = new();

        //InventoryPanel = CreatePanel(config.inventoryPanelPrefab);
        //ShopPanel = CreatePanel(config.shopPanelPrefab);
        //PausePanel = CreatePanel(config.pausePanelPrefab);
    }

    public void Refresh()
    {
        for (int i = 0; i < openPanels.Count; i++)
            openPanels[i].Refresh();
    }

    public T CreatePanel<T>(T prefab) where T : Panel
    {
        var panel = Instantiate(prefab);
        panel.Initialize();
        return panel;
    }

    public void OpenPanel(Panel panel)
    {
        if (!panel.CanOpen()) return;
        panel.Open();
        openPanels.Add(panel);
    }

    public void ClosePanel(Panel panel)
    {
        if (!panel.CanClose()) return;
        panel.Close();
        openPanels.Remove(panel);
    }
}
