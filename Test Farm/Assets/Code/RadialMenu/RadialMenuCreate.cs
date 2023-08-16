using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadialMenuCreate
{
    public List<GameObject> Items => _items;

    private RadialMenuView _radialMenuView;
    private List<GameObject> _items;

    public RadialMenuCreate(RadialMenuView radialMenuView)
    {
        _radialMenuView = radialMenuView;
        _items = new List<GameObject>();
    }

    public void Create(RadialMenuSO radialMenuSO)
    {
        int count = radialMenuSO.Items.Count;
        int angle = 360 / count;

        for(int i = 1; i <= count; i++)
        {
            var obj = GameObject.Instantiate(_radialMenuView.Prefab, _radialMenuView.transform);
            obj.AddComponent<Image>().sprite = radialMenuSO.Items[i - 1].ItemSprite;
            obj.AddComponent<Button>();
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
