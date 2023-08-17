using UnityEngine;

public class RadialMenuActivator : MonoBehaviour
{
    private RadialMenuView _radialMenuView;
    private RadialMenuCreate _radialMenuCreate;

    public RadialMenuActivator(RadialMenuView radialMenuView, RadialMenuCreate radialMenuCreate)
    {
        _radialMenuView = radialMenuView;
        _radialMenuCreate = radialMenuCreate;
    }


    public void Active(RadialMenuSO radialMenuSO, Transform activeObjectTransform)
    {
        _radialMenuView.RadialMenuObject.SetActive(true);
        _radialMenuView.RadialMenuImageTransform.position = activeObjectTransform.position;
        _radialMenuCreate.Create(radialMenuSO);
    }

    public void Deactive()
    {
        _radialMenuView.RadialMenuObject.SetActive(false);
        _radialMenuCreate.DeleteOldItems();
    }
}
