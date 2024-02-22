using EnumTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public CineMachineController controller;
    public Character[] characters;
    public CharacterClass characterClass;
    //public Player Player { get; private set; }
    public PlayerSO player;
    //public GameObject[] targetObject;
    public Transform CameraLookAtBox;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        DontDestroyOnLoad(Instance);
        Debug.Log(characterClass);
    }

    public void CancelSelectCharacter()
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].selectEffect.enabled = false;
            characters[i].Animator.SetBool(characters[i].AnimationData.AttackParameterHash, false);
            characters[i].Animator.SetBool(characters[i].AnimationData.BaseAttackParameterHash, false);
        }
    }
    public void OnClickStart()
    {
        //LoadMainScene();
        if (characterClass != CharacterClass.None)
        {
            SceneManager.LoadScene("MainScene");
            switch (characterClass)
            {
                case CharacterClass.Warrior:
                    //targetObject[0].SetActive(true);
                    //Player = targetObject[0].GetComponent<Player>();
                    LoadMainScene();
                    break;
                case CharacterClass.Magichian:
                    //targetObject[1].SetActive(true);
                    //Player = targetObject[1].GetComponent<Player>();
                    LoadMainScene();
                    break;
                case CharacterClass.Ranger:
                    //targetObject[2].SetActive(true);
                    //Player = targetObject[2].GetComponent<Player>();
                    LoadMainScene();
                    break;
            }


        }
        else Debug.Log("캐릭터 선택해주세요");

    }

    public void LoadMainScene()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        SceneManager.LoadScene("MainScene");
        yield return new WaitForSeconds(0.1f);
        switch (characterClass)
        {
            case CharacterClass.Warrior:
                Instantiate(player.chracterPrefabs[1]);
                Instantiate(player.chracterPrefabs[3]);
                controller = GameObject.FindGameObjectWithTag("VirtualCamera").GetComponent<CineMachineController>();
                controller.SelectTarget();
                break;
            case CharacterClass.Magichian:
                Instantiate(player.chracterPrefabs[0]);
                Instantiate(player.chracterPrefabs[3]);
                controller = GameObject.FindGameObjectWithTag("VirtualCamera").GetComponent<CineMachineController>();
                controller.SelectTarget();
                break;
            case CharacterClass.Ranger:
                Instantiate(player.chracterPrefabs[2]);
                Instantiate(player.chracterPrefabs[3]);
                controller = GameObject.FindGameObjectWithTag("VirtualCamera").GetComponent<CineMachineController>();
                controller.SelectTarget();
                break;
        }
        //yield return new WaitForSeconds(0.2f);
        //Player.stateMachine = new PlayerStateMachine(Player);
    }


}
