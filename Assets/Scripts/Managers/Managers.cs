using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static Managers s_instace;
    private static Managers Instance { get { Init(); return s_instace; } }

    private GameManager _gameManager;
    private ResourceManager _resource = new ResourceManager();

    public static GameManager GameManager { get { return Instance._gameManager; } }
    public static ResourceManager Resource { get { return Instance._resource; } }

    [SerializeField] private GameObject player;

    private void Awake() {
        _gameManager = new GameManager(player);
    }

    void Start()
    {
        Init();
    }

    static void Init() {
        if (s_instace == null) {
            GameObject obj = GameObject.Find("Managers");
            if (obj == null) {
                obj = new GameObject { name = "Managers" };
                obj.AddComponent<Managers>();
            }
            s_instace = obj.GetComponent<Managers>();
        }
    }
}
