using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialMenuCreate
{
    public List<GameObject> Items => _items;

    private RadialMenuView _radialMenuView;
    private RadialMenuItemClick _radialMenuItemClick;
    private List<GameObject> _items;

    public RadialMenuCreate(RadialMenuView radialMenuView, RadialMenuItemClick radialMenuItemClick)
    {
        _radialMenuView = radialMenuView;
        _radialMenuItemClick = radialMenuItemClick;
        _items = new List<GameObject>();
    }

    public void Create(RadialMenuSO radialMenuSO)
    {
        int count = radialMenuSO.Items.Count;
        int angle = 360 / count;

        for(int i = 1; i <= count; i++)
        {
            var obj = GameObject.Instantiate(_radialMenuView.Prefab, _radialMenuView.RadialMenuImageTransform);
            obj.GetComponent<Image>().sprite = radialMenuSO.Items[i - 1].ItemSprite;
            obj.GetComponent<RadialMenuItemView>().ItemMenu = radialMenuSO.Items[i - 1];
            _radialMenuItemClick.Subscribe(obj.GetComponent<RadialMenuItemView>());
            _items.Add(obj);

            var transform = obj.GetComponent<Transform>();

            transform.Rotate(new Vector3(0, 0, i * angle));
            transform.localPosition = transform.up * radialMenuSO.Radius;
            transform.rotation = Quaternion.identity;
        }
    }

    public void DeleteOldItems()
    {
        for(int i = 0; i < _items.Count; i++)
        {
            GameObject.Destroy(_items[i]);
        }

        _items.Clear();
    }
}
