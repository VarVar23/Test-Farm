using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class AnimationRadialItem
{
    private AnimationRadialItemSO _model;

    public AnimationRadialItem(AnimationRadialItemSO animationRadialItemSO)
    {
        _model = animationRadialItemSO;
    }

    public void Click(Image itemImage, Vector3 parentPosition, Transform itemTransform, ItemMenu itemMenu)
    {
        itemImage.transform.position = itemTransform.position;
        itemImage.sprite = itemMenu.ItemSprite;
        itemImage.gameObject.SetActive(true);

        itemImage.transform.DOMove(parentPosition, _model.TimeMove)
            .SetEase(_model.EaseMove);
        itemImage.DOColor(_model.FinishColor, _model.TimeFinishColorItem)
            .SetEase(_model.EaseColor)
            .OnComplete(() => DefaultImage(itemImage));
    }

    public void Enter(Image itemImage)
    {
        itemImage.transform.DOScale(_model.NewScale, _model.TimeNewScaleItem);
    }

    public void Exit(Image itemImage)
    {
        itemImage.transform.DOScale(1f, _model.TimeOldScaleItem);
    }

    private void DefaultImage(Image itemImage)
    {
        itemImage.gameObject.SetActive(false);
        itemImage.color = Color.white;
    }
}
