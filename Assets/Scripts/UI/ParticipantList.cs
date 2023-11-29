using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ParticipantList : MonoBehaviour
{
    [SerializeField] private GameObject content;

    public void SetListNames() {
        GameObject name = Managers.Resource.Instantiate("ParticipantName", content.transform);
        GameObject player = GameManager.player;
        name.GetComponent<TextMeshProUGUI>().text = player.GetComponent<PlayerScript>().GetName();

        List<GameObject> gameObjects = GameManager.Instance.gameObjects;
        for(int i = 0; i < gameObjects.Count; ++i) {
            GameObject npcName = Managers.Resource.Instantiate("ParticipantName", content.transform);
            npcName.GetComponent<TextMeshProUGUI>().text = gameObjects[i].GetComponent<NPC>().npcName;
        }
    }

    public void RemoveNames() {
        foreach (Transform child in content.transform) {
            Destroy(child.gameObject);
        }
    }
}
