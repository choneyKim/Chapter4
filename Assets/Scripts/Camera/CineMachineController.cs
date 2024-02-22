using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CineMachineController : MonoBehaviour
{
    public Transform Target { get; private set; }
    public GameManager _gameManager;
    public CinemachineVirtualCamera VirtualCamera;
    public GameManager GameManager {  get { return _gameManager; } }

    private void Awake()
    {
        VirtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public void init(GameManager gameManager)
    {
        _gameManager = gameManager;
    }
    public void SelectTarget()
    {
        Target = GameObject.FindGameObjectWithTag("LookPoint").transform;
        VirtualCamera.Follow = Target;
        VirtualCamera.LookAt = Target;
    }


}
