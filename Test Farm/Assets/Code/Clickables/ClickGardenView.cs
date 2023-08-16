using UnityEngine;
using UnityEngine.UI;

public class ClickGardenView : MonoBehaviour, IClickMenu
{
    [SerializeField] private RadialMenuSO _radialMenuSO;
    [SerializeField] private Button _clickButton;

    public RadialMenuSO RadialMenuSO => _radialMenuSO;
    public Button ClickButton => _clickButton;
}