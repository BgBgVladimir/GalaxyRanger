using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RotationBehaviour:ScriptableObject
{
    public Transform _transform;

    public abstract void Init(Transform transform);
    public abstract void Rotate();
}
