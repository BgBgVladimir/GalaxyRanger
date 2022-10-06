using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoweBehaviour : ScriptableObject
{
    public Rigidbody2D _rigidBody2D;
    public float moweSpeed;

    public abstract void Init(Rigidbody2D rigidBody2D);
    public abstract void Mowe();
}
