using UnityEngine;
using UnityEngine.UI;

public class RadialMenuView : MonoBehaviour
{
    [SerializeField] private GameObject _radialMenuObject;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Button _closeButton;

    public GameObject RadialMenuObject => _radialMenuObject;
    public GameObject Prefab => _prefab;    
    public Button CloseButton => _closeButton;
}
