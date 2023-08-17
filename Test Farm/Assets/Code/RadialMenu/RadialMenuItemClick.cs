using UnityEngine;
using UnityEngine.UI;
using System;

public class RadialMenuItemClick
{
    public Action ClickAction;
    private Image _itemImage;
    private AnimationRadialItem _animationRadialItem;

    public RadialMenuItemClick(Image itemImage, AnimationRadialItem animationRadialItem)
    {
        _itemImage = itemImage;
        _animationRadialItem = animationRadialItem;
    }

    public void Subscribe(RadialMenuItemView radialMenuItemView)
    {
        radialMenuItemView.ClickItemAction += Click;
        radialMenuItemView.EnterItemAction += Enter;
        radialMenuItemView.ExitItemAction += Exit;
    }

    private void Click(Transform itemTransform, ItemMenu itemMenu)
    {
        var parent = itemTransform.parent;

        _animationRadialItem.Click(_itemImage, parent.position, itemTransform, itemMenu);
        ClickAction?.Invoke();
    }

    private void Enter(Image itemImage)
    {
        _animationRadialItem.Enter(itemImage);
    }

    private void Exit(Image itemImage)
    {
        _animationRadialItem.Exit(itemImage);
    }
}
