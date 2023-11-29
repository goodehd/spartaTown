using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    //[SerializeField] private SpriteRenderer armRenderer;
    //[SerializeField] private Transform armPivot;

    private SpriteRenderer _characterRenderer;
    private TopDownCharactreController _controller;

    private void Awake() {
        _controller = GetComponent<TopDownCharactreController>();
        _characterRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection) {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction) {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //armRenderer.flipY = Mathf.Abs(rotZ) > 90f;
        _characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        //armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    public void SetCharacterRenderer(SpriteRenderer renderer) {
        _characterRenderer = renderer;
    }
}
