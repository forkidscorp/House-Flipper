using UnityEngine;

[System.Serializable]
public class SkinConfig
{
    [SerializeField] private string skinName;
    [SerializeField] private Sprite previewImage;
    [SerializeField] private GameObject prefab;

    public string SkinName => skinName;
    public Sprite PreviewImage => previewImage;
    public GameObject Prefab => prefab;
}

