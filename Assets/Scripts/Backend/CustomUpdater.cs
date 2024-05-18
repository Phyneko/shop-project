using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomUpdater 
{
    private List<IRefresh> currentRefresh;

    public void Initialize()
    {
        currentRefresh = new ();
    }

    public void Refresh()
    {
        for (int i = 0; i < currentRefresh.Count; i++)
            currentRefresh[i].Refresh();
    }

    public void Add(IRefresh item)
    {
        if (currentRefresh.Contains(item))
        {
            Debug.LogError($"Trying to ADD {item} when it's in the list");
            return;
        }

        currentRefresh.Add(item);
    }

    public void Remove(IRefresh item) 
    {
        if (!currentRefresh.Contains(item))
        {
            Debug.LogError($"Trying to remove {item} when it's not in the list");
            return;
        }

        currentRefresh.Remove(item);
    }
}
