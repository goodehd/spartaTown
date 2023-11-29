using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    public enum CharacterName {
        Penguin,
        Mercy
    }

    [SerializeField] private GameObject InforUI;
    [SerializeField] private Sprite[] charImages;
    [SerializeField] private Image previewImage;

    public void PenguinClick() {
        previewImage.sprite = charImages[(int)CharacterName.Penguin];
        InforUI.GetComponent<ChangeName>().SetCharacterName(CharacterName.Penguin);
        ClickAfter();
    }

    public void MercyClick() {
        previewImage.sprite = charImages[(int)CharacterName.Mercy];
        InforUI.GetComponent<ChangeName>().SetCharacterName(CharacterName.Mercy);
        ClickAfter();
    }

    private void ClickAfter() {
        this.gameObject.SetActive(false);
    }

}
