using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "InteriorItemConfig", menuName = "Configs/Interior Item")]
public class InteriorItemConfig : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private string displayName;
    [SerializeField] private Sprite icon;
    [SerializeField] private List<SkinConfig> skins;
    [SerializeField] private List<ToolType> requiredTools;

    public string Id => id;
    public string DisplayName => displayName;
    public Sprite Icon => icon;
    public IReadOnlyList<SkinConfig> Skins => skins;
    public IReadOnlyList<ToolType> RequiredTools => requiredTools;
}

