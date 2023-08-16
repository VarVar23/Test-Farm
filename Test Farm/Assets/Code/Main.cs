using UnityEngine;

public class Main : MonoBehaviour
{
    #region View

    [SerializeField] private RadialMenuView _radialMenuView;
    [SerializeField] private ClickTreeView _clickTreeView;
    [SerializeField] private ClickGardenView _clickGardenView;

    #endregion


    #region Controller

    private RadialMenuCreate _radialMenuCreate;
    private RadialMenuActivator _radialMenuActivator;
    private ClickMenuController _clickMenuController;

    #endregion


    #region Model

    [SerializeField] private RadialMenuSO _radialMenuSO;

    #endregion

    #region Interface

    private IClickMenu[] _iClickMenu;

    #endregion

    private void Awake()
    {
        InitializeInterface();
        ControllersInitialize();

        _clickMenuController.Awake();
    }

    private void InitializeInterface()
    {
        _iClickMenu = new IClickMenu[2] { _clickGardenView, _clickTreeView };
    }

    private void ControllersInitialize()
    {
        _radialMenuCreate = new RadialMenuCreate(_radialMenuView);
        _radialMenuActivator = new RadialMenuActivator(_radialMenuView, _radialMenuCreate);
        _clickMenuController = new ClickMenuController(_iClickMenu, _radialMenuActivator, _radialMenuView);
    }
}