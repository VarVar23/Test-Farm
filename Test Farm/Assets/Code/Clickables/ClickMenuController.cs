using UnityEngine;

public class ClickMenuController 
{
    private IClickMenu[] _clickMenus;
    private RadialMenuActivator _radialMenuActivator;
    private RadialMenuView _radialMenuView;
    private RadialMenuItemClick _radialMenuItemClick;

    public ClickMenuController(IClickMenu[] clickMenus, RadialMenuActivator radialMenuActivator, RadialMenuView radialMenuView, RadialMenuItemClick radialMenuItemClick)
    {
        _clickMenus = clickMenus;
        _radialMenuActivator = radialMenuActivator;
        _radialMenuView = radialMenuView;
        _radialMenuItemClick = radialMenuItemClick;
    }

    public void Awake()
    {
        for(int i = 0; i < _clickMenus.Length; i++)
        {
            int j = i;
            _clickMenus[i].ClickAction += ActivateMenu;
        }

        _radialMenuView.CloseButton.onClick.AddListener(DeactiveMenu);
        _radialMenuItemClick.ClickAction += DeactiveMenu;
    }

    private void ActivateMenu(RadialMenuSO radialMenuSO, Transform activeObjectTransform)
    {
        _radialMenuActivator.Active(radialMenuSO, activeObjectTransform);

        foreach(var clickObject in _clickMenus)
        {
            clickObject.OneClick = false;
        }
    }

    private void DeactiveMenu()
    {
        _radialMenuActivator.Deactive();

        foreach (var clickObject in _clickMenus)
        {
            clickObject.OneClick = true;
        }
    }
}
