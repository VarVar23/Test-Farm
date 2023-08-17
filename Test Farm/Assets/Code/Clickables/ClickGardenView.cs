using System;
using UnityEngine;

public class ClickGardenView : MonoBehaviour, IClickMenu
{
    [SerializeField] private RadialMenuSO _radialMenuSO;

    public RadialMenuSO RadialMenuSO => _radialMenuSO;
    public Action<RadialMenuSO, Transform> ClickAction { get => _clickAction; set => _clickAction = value; }
    public bool OneClick { get => _oneClick; set => _oneClick = value; }

    private Action<RadialMenuSO, Transform> _clickAction;
    private bool _oneClick = true;

    private void OnMouseDown()
    {
        if(_oneClick)
            _clickAction?.Invoke(_radialMenuSO, transform);
    }
}