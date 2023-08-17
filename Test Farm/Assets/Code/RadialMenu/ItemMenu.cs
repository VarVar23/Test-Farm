using System;
using UnityEngine;

[Serializable]
public class ItemMenu
{
    public float ItemTimeAction;
    public Sprite ItemSprite;
    public Action ItemAction;

    public void ActiveAction()
    {
        ItemAction?.Invoke();
    }
}
