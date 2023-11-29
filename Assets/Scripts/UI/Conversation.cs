using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    [SerializeField] private TMP_Text conver;

    public void SetConver(string convers) {
        conver.text = convers;
    }

    public void UIClick() {
        GameManager.Instance.PlayerKeyRock = false;
        Destroy(this.gameObject);
    }
}
