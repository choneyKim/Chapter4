using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemDatas", menuName = "New Item")]
public class ItemSO : ScriptableObject
{
    [field: SerializeField] public ItemData ItemData { get; private set; }


}

