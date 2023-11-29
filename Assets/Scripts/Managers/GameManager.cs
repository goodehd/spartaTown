using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    [SerializeField] private GameObject _player;

    private static GameManager s_instace;

    public List<GameObject> gameObjects { get; } = new List<GameObject>();
    public bool PlayerKeyRock { get; set; } = true;

    void Start() {
        Init();
    }

    static void Init() {
        if (s_instace == null) {
            GameObject obj = GameObject.Find("GameManager");
            if (obj == null) {
                obj = new GameObject { name = "GameManager" };
                obj.AddComponent<Managers>();
            }
            s_instace = obj.GetComponent<GameManager>();
        }
    }

    public static GameObject player { get { return Instance._player; } }
    public static GameManager Instance { get { Init(); return s_instace; } }

}
