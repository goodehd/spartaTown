using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private GameObject textUI;
    public string npcName;

    private void Awake() {
        GameManager.Instance.gameObjects.Add(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        textUI.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision) {
        textUI.SetActive(false);
    }

    public void ClickBell() {
        GameManager.Instance.PlayerKeyRock = true;
        Managers.Resource.CreateConversation("ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?" +
            "ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?" +
            "ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì³ª¿ä?ºÎ¸£¼Ì");
        textUI.SetActive(false);
    }
}
