using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}

