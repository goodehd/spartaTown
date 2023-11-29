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

    private void Start() {
        Managers.GameManager.GameObjects.Add(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        textUI.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision) {
        textUI.SetActive(false);
    }

    public void ClickBell() {
        Managers.GameManager.PlayerKeyRock = true;
        Managers.Resource.CreateConversation("�θ��̳���?�θ��̳���?�θ��̳���?�θ��̳���?�θ��̳���?�θ��̳���?" +
            "�θ��̳���?�θ��̳���?�θ��̳���?�θ��̳���?�θ��̳���?�θ��̳���?�θ��̳���?�θ��̳���?" +
            "�θ��̳���?�θ��̳���?�θ��̳���?�θ���");
        textUI.SetActive(false);
    }
}
