using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticipantListBnt : MonoBehaviour
{
    [SerializeField] private GameObject Playerlist;

    public void ParticipantsClick () {
        Playerlist.SetActive(Playerlist.activeSelf ? false : true);

        if (Playerlist.activeSelf)
            Playerlist.GetComponent<ParticipantList>().SetListNames();
        else
            Playerlist.GetComponent<ParticipantList>().RemoveNames();
    }
}
