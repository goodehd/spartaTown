using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewClick : MonoBehaviour
{
    [SerializeField] GameObject characterSelect;

    public void OnPreviewClick() {
        characterSelect.SetActive(true);
    }
}
