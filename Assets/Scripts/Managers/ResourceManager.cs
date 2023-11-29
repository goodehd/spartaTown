using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class ResourceManager
{
    public T Load<T> (string path) where T : Object {
        return Resources.Load<T> (path);
    }

    public GameObject Instantiate(string path, Transform parent = null) {
        GameObject prefab = Load<GameObject>($"Prefabs/{path}");
        if(prefab == null) {
            Debug.Log($"Filed to load prefab : {path}");
            return null;
        }
        return Object.Instantiate(prefab, parent);
    }

    public void Destroy (GameObject obj) {
        if(obj == null) {
            return;
        }
        Object.Destroy(obj);
    }

    public GameObject CreateConversation(string conver) {
        GameObject prefab = Load<GameObject>($"Prefabs/ConverCanvas");
        if( prefab == null ) {
            Debug.Log($"Filed to load prefab : ConverCanvas");
            return null;
        }
        GameObject newObj = Object.Instantiate(prefab);
        newObj.GetComponent<Conversation>().SetConver(conver);
        return newObj;
    }
}
