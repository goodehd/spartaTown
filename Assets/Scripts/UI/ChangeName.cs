using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    [SerializeField] private GameObject root;
    [SerializeField] private GameObject inGameBtn;

    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private Image blruImage;

    private SelectCharacter.CharacterName characterName = SelectCharacter.CharacterName.Penguin;
    private int maxChar = 10;

    private void Start() {
        nameInputField.characterLimit = maxChar;
    }

    public void OnClickInput() {
        int Length = nameInputField.text.Length;
        if (Length < 2 || Length > 10)
            return;

        GameObject player = Managers.GameManager.player;
        PlayerScript playerScript = player.GetComponent<PlayerScript>();
        playerScript.ChangeName(nameInputField.text);
        playerScript.ChangeCharacter(characterName);

        root.SetActive(false);
        inGameBtn.SetActive(true);
        blruImage.gameObject.SetActive(false);
        Managers.GameManager.PlayerKeyRock = false;
    }

    public void SetCharacterName(SelectCharacter.CharacterName name) {
        characterName = name;
    }
}
