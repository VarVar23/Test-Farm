using UnityEngine;
using UnityEngine.UI;

public class ClickTreeView : MonoBehaviour, IClickMenu
{
    [SerializeField] private RadialMenuSO _radialMenuSO;
    [SerializeField] private Button _clickButton;

    public RadialMenuSO RadialMenuSO => _radialMenuSO;
    public Button ClickButton => _clickButton;
}
