using System;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class ItemMenu
{
    public Sprite ItemSprite;
    public Action ItemAction;

    public void ActiveAction()
    {
        ItemAction?.Invoke();
    }
}
