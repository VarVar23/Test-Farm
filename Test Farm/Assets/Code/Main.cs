using UnityEngine;

public class Main : MonoBehaviour
{
    #region View
    [SerializeField] private RadialMenuView _radialMenuView;
    [SerializeField] private ClickTreeView _clickTreeView;
    [SerializeField] private ClickGardenView _clickGardenView;
    [SerializeField] private AnimationItemMenuMoveView _animationItemMenuMoveView;

    #endregion


    #region Controller

    private RadialMenuCreate _radialMenuCreate;
    private RadialMenuActivator _radialMenuActivator;
    private RadialMenuItemClick _radialMenuItemClick;
    private ClickMenuController _clickMenuController;
    private AnimationRadialItem _animationRadialItem;


    #endregion


    #region Model

    [SerializeField] private AnimationRadialItemSO _animationRadialItemSO;

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
        _animationRadialItem = new AnimationRadialItem(_animationRadialItemSO);
        _radialMenuItemClick = new RadialMenuItemClick(_animationItemMenuMoveView.MoveImage, _animationRadialItem);
        _radialMenuCreate = new RadialMenuCreate(_radialMenuView, _radialMenuItemClick);
        _radialMenuActivator = new RadialMenuActivator(_radialMenuView, _radialMenuCreate);

        _clickMenuController = new ClickMenuController(_iClickMenu, _radialMenuActivator, _radialMenuView, _radialMenuItemClick);
    }
}