using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Transform healthBar;
    private float _health = 1.0f;

    public float Health {
        get {
            return _health;
        }
        set {
            if(value > 1.0f) _health = 1.0f;
            else if (value < .0f) _health = .0f;
            else _health = value;
            
            healthBar.transform.localScale = new Vector3(1f, (float) _health, 1f);
        }
    }

    private void Awake() {
        Health = _health;
    }
}
