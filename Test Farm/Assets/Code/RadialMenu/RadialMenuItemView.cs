using UnityEngine;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Image))]
public class RadialMenuItemView : MonoBehaviour
{
    public Action<Image> EnterItemAction;
    public Action<Image> ExitItemAction;
    public Action<Transform, ItemMenu> ClickItemAction;
    public ItemMenu ItemMenu;
    private Image _itemImage;

    private void Start()
    {
        _itemImage = GetComponent<Image>();
    }

    public void Enter()
    {
        EnterItemAction?.Invoke(_itemImage);
    }

    public void Exit()
    {
        ExitItemAction?.Invoke(_itemImage);
    }

    public void Click()
    {
        ClickItemAction?.Invoke(transform, ItemMenu);
    }
}

