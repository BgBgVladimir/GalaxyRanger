using UnityEngine;

public abstract class RotationBehaviour:ScriptableBehaviour
{
    public Transform _transform;

    public override void Init(Unit _unit)
    {

    }
    public abstract void Rotate();

    public virtual void SetTarget(Transform transformTarget)
    {
    }
    public virtual void SetTarget(Vector2 positionTarget)
    {
    }
}
