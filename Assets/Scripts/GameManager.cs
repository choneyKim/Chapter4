using EnumTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Character[] characters;
    public CharacterClass characterClass;

    private void Awake()
    {
        if(Instance == null)
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
        if (characterClass != CharacterClass.None)
        {
            SceneManager.LoadScene("MainScene");
        }
        else Debug.Log("캐릭터 선택해주세요");
            
    }

}
