using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "RoomConfig", menuName = "Configs/Room")]
public class RoomConfig : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private string displayName;
    [SerializeField] private Sprite icon;
    [SerializeField] private List<InteriorItemConfig> interiorItems;

    public string Id => id;
    public string DisplayName => displayName;
    public Sprite Icon => icon;
    public IReadOnlyList<InteriorItemConfig> InteriorItems => interiorItems;
}

