using System;
using UnityEngine;

public interface IClickMenu
{
    public RadialMenuSO RadialMenuSO { get; }
    public Action<RadialMenuSO, Transform> ClickAction { get; set; }
    public bool OneClick { get; set; }
}
