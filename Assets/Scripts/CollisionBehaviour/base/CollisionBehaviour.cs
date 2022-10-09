using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CollisionBehaviour:ScriptableObject
{
    private Unit unit;
    public float moweSpeed;

    public virtual void Init(Unit _unit)
    {
        unit=_unit;
    }

    public abstract void OnTriggerEnter(Transform triggeredObject);
}
