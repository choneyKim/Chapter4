using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : MonoBehaviour
{
    string id, name, discription, armorType, point, price, pointType;
    public List<ItemData> data;
    public ItemData(string _id, string _name, string _discription, string _armorType, string _point, string _price, string _pointType)
    {
        id = _id;
        name = _name;
        discription = _discription;
        armorType = _armorType;
        point = _point;
        price = _price;
        pointType = _pointType;
    }

    //void Start()
    //{
    //    TextAsset itemdatabase = Resources.Load("ItemData")
    //    string[] line = itemdatabase.Substring(0, )
    //}

    //public void LoadData()
    //{
    //    data = JsonUtility.
    //}
}
