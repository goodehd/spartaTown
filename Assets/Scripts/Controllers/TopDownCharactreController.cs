using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharactreController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    private float _timeSinceLastAttack = float.MaxValue;
    protected bool IsAttacking { get; set; }

    protected virtual void Update() {
        HandleAttackDelay();
    }

    private void HandleAttackDelay() {
        if(_timeSinceLastAttack <= 0.2f) {
            _timeSinceLastAttack += Time.deltaTime; // Å×½ºÆ®
        }

        if(IsAttacking && _timeSinceLastAttack > 0.2f) {
            _timeSinceLastAttack = 0;
            CallAttackEvent();
        }
    }

    public void CallMoveEvent(Vector2 direction) {
        if (Managers.GameManager.PlayerKeyRock)
            return;

        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction) {
        if (Managers.GameManager.PlayerKeyRock)
            return;

        OnLookEvent?.Invoke(direction);
    }

    public void CallAttackEvent() {
        if (Managers.GameManager.PlayerKeyRock)
            return;

        OnAttackEvent?.Invoke();
    }
}

////[SerializeField] private float speed = 5f;

//// Start is called before the first frame update
//void Start() {

//}

//// Update is called once per frame
//void Update() {
//    //float x = Input.GetAxisRaw("Horizontal");
//    //float y = Input.GetAxisRaw("Vertical");

//    //transform.position += new Vector3(x, y) * Time.deltaTime * speed;
//}