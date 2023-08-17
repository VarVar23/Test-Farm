using DG.Tweening;
using UnityEngine;

[CreateAssetMenu(fileName = "AnimationRadialItemSO", menuName = "Config/AnimationRadialItemSO", order = 0)]
public class AnimationRadialItemSO : ScriptableObject
{
    [Header("Move Item")]
    [SerializeField] private float _timeMove = 1;
    [SerializeField] private Ease _easeMove = Ease.OutCubic;
    [SerializeField] private Color32 _finishColorItem = new Color32(0, 0, 0, 0);
    [SerializeField] private float _timeFinishColorItem = 1;
    [SerializeField] private Ease _easeColor = Ease.InCubic;

    [Header("Enter/Exit Item")]
    [SerializeField] private float _newScaleItem = 1.2f;
    [SerializeField] private float _timeNewScaleItem = 0.4f;
    [SerializeField] private float _timeOldScaleItem = 0.4f;

    public float TimeMove => _timeMove;
    public Ease EaseMove => _easeMove;
    public Color32 FinishColor => _finishColorItem;
    public float TimeFinishColorItem => _timeFinishColorItem;
    public Ease EaseColor => _easeColor;

    public float NewScale => _newScaleItem;
    public float TimeNewScaleItem => _timeNewScaleItem;
    public float TimeOldScaleItem => _timeOldScaleItem;
}
