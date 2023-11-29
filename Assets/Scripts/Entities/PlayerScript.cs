using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private TMP_Text playerName;
    private TopDownMovement moveMent;
    private TopDownAimRotation aimRotation;

    private SelectCharacter.CharacterName characterName = SelectCharacter.CharacterName.Penguin;
    [SerializeField] private GameObject curPerfab;

    private void Awake() {
        moveMent = GetComponent<TopDownMovement>();
        aimRotation = GetComponent<TopDownAimRotation>();
        //GameManager.Instance.gameObjects.Add(this.gameObject);
    }

    public void ChangeName(string name) {
        playerName.text = name;
    }

    public string GetName() {
        return playerName.text;
    }

    public void ChangeCharacter(SelectCharacter.CharacterName name) {
        if (characterName == name)
            return;

        if (curPerfab != null)
            Destroy(curPerfab);

        curPerfab = Managers.Resource.Instantiate(name.ToString(), this.transform);
        characterName = name;
        moveMent.SetAinimator(curPerfab.GetComponent<Animator>());
        aimRotation.SetCharacterRenderer(curPerfab.GetComponent<SpriteRenderer>());
    }
}
