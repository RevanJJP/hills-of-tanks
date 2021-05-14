using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;
public class Missile : MonoBehaviour
{
    [SerializeField] public Transform missileAvatar;
    [SerializeField] public Rigidbody2D missileRigidbody;
    [SerializeField] public Animator missileAnimatior;

    private void OnTriggerEnter2D(Collider2D other) {
        Player player = other.GetComponentInParent<Player>();
        if(player != null) {
            CLog.Info("Hit Player!");
            missileAnimatior.SetTrigger("MissileHit");
            player.Health -= 1;
        }
        else    {
            CLog.Info($"Missed! Hitted {other.name}");
            missileAnimatior.SetTrigger("MissileMiss");

        }
        missileRigidbody.Sleep();
    }
}
