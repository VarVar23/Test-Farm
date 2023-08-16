public class ClickMenuController 
{
    private IClickMenu[] _clickMenus;
    private RadialMenuActivator _radialMenuActivator;
    private RadialMenuView _radialMenuView;

    public ClickMenuController(IClickMenu[] clickMenus, RadialMenuActivator radialMenuActivator, RadialMenuView radialMenuView)
    {
        _clickMenus = clickMenus;
        _radialMenuActivator = radialMenuActivator;
        _radialMenuView = radialMenuView;
    }

    public void Awake()
    {
        for(int i = 0; i < _clickMenus.Length; i++)
        {
            int j = i;
            _clickMenus[i].ClickButton.onClick.AddListener(() => ActivateMenu(_clickMenus[j].RadialMenuSO));
        }

        _radialMenuView.CloseButton.onClick.AddListener(DeactiveMenu);
    }

    private void ActivateMenu(RadialMenuSO radialMenuSO)
    {
        _radialMenuActivator.Active(radialMenuSO);
    }

    private void DeactiveMenu()
    {
        _radialMenuActivator.Deactive();
    }
}
