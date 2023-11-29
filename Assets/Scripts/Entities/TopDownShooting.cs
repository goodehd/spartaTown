using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownShooting : MonoBehaviour
{
    private TopDownCharactreController _contoller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 _aimDirection = Vector2.right;

    private void Awake() {
        _contoller = GetComponent<TopDownCharactreController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _contoller.OnAttackEvent += OnShoot;
        _contoller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection) {
        _aimDirection = newAimDirection;
    }

    private void OnShoot() {
        CreateProjecrile();
    }

    private void CreateProjecrile() {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
