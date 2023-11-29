using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoChange : MonoBehaviour
{
    [SerializeField] private GameObject root;

    public void ChangeClick() {
        bool rock = Managers.GameManager.PlayerKeyRock;
        root.SetActive(root.activeSelf ? false : true);
        Managers.GameManager.PlayerKeyRock = root.activeSelf ? true : false;
    }
}
