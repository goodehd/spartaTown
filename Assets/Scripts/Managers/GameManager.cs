using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager {

    private GameObject _player;

    public List<GameObject> GameObjects { get; } = new List<GameObject>();
    public bool PlayerKeyRock { get; set; } = true;

    public GameManager(GameObject player) {
        _player = player;
    }

    public GameObject player { get { return _player; } }
}
