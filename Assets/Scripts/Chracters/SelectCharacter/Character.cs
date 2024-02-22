using EnumTypes;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    [field: SerializeField] public PlayerSO Data { get; private set; }
    [field: SerializeField] public PlayerAnimationData AnimationData { get; private set; }
    public Animator Animator { get; set; }
    public Light selectEffect;
    private void Awake()
    {
        selectEffect = GetComponentInChildren<Light>();
        Animator = GetComponentInChildren<Animator>();
        AnimationData.Initialize();

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.Instance.CancelSelectCharacter();
            Animator.SetBool(AnimationData.AttackParameterHash, true);
            Animator.SetBool(AnimationData.BaseAttackParameterHash, true);
            selectEffect.enabled = true;
            switch (gameObject.name)
            {
                case "Character1":
                    GameManager.Instance.characterClass = CharacterClass.Warrior;
                    Debug.Log(GameManager.Instance.characterClass);
                    break;
                case "Character2":
                    GameManager.Instance.characterClass = CharacterClass.Magichian;
                    Debug.Log(GameManager.Instance.characterClass);
                    break;
                case "Character3":
                    GameManager.Instance.characterClass = CharacterClass.Ranger;
                    Debug.Log(GameManager.Instance.characterClass);
                    break;
            }
        }
            

    }
}