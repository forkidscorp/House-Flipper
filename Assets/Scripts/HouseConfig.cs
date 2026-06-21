using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "HouseConfig", menuName = "Configs/House")]
public class HouseConfig : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private string displayName;
    [SerializeField] private Sprite previewImage;
    [SerializeField] private List<RoomConfig> rooms;

    public string Id => id;
    public string DisplayName => displayName;
    public Sprite PreviewImage => previewImage;
    public IReadOnlyList<RoomConfig> Rooms => rooms;
}

