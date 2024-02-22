using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[Serializable]
public class ChracterPrefab
{
    public GameObject characterPrefab;
}
[Serializable]
public class ChracterData
{
    [SerializeField] public List<ChracterPrefab> chracterPrefabs {  get;  set; }

}
