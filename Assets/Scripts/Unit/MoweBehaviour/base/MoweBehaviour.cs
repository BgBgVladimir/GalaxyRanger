using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoweBehaviour :ScriptableBehaviour
{
    [SerializeField] protected Rigidbody2D rigidBody2D;
    public float moweSpeed;

    public virtual void SetTarget(Transform transformTarget)
    {
    }
    public virtual void SetTarget(Vector2 positionTarget)
    {
    }
}
