using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RadialMenuSO", menuName = "Config/RadialMenuSO", order = 0)]
public class RadialMenuSO : ScriptableObject
{
    [SerializeField] private List<ItemMenu> _items;
    [SerializeField] private float _radius;

    public List<ItemMenu> Items => _items;
    public float Radius => _radius;
}
