using EnumTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[Serializable]
public class ItemInfoData
{
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public int itemPoint;
    public int itemPrice;
    public Sprite typeIcon_Equip;
    public Sprite typeIcon_Shop;
}
[Serializable]
public class ItemData
{
    [field: SerializeField] public List<ItemInfoData> ItemInfoDatas { get; private set; }
    public int GetItemsCount() { return ItemInfoDatas.Count; }
    public ItemInfoData GetItemInfo(int index) { return ItemInfoDatas[index]; }
}


