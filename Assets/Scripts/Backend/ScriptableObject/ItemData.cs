using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "SO/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
    public string displayName;
    public string description;
    public Sprite icon;
    public int cost;
}
