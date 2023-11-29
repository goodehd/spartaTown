using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private readonly string test = "IsMove";

    private TopDownCharactreController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    private void Awake() {
        _controller = GetComponent<TopDownCharactreController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Start() {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate() {
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction) {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction) {
        direction = direction * 5;
        _rigidbody.velocity = direction;
        _animator.SetBool(test, direction != Vector2.zero);
    }

    public void SetAinimator(Animator animator) {
        _animator = animator;
    }
}
