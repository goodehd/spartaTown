using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoChange : MonoBehaviour
{
    [SerializeField] private GameObject root;

    public void ChangeClick() {
        bool rock = GameManager.Instance.PlayerKeyRock;
        root.SetActive(root.activeSelf ? false : true);
        GameManager.Instance.PlayerKeyRock = root.activeSelf ? true : false;
    }
}
