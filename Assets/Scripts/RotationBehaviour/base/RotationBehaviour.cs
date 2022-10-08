using UnityEngine;

public abstract class RotationBehaviour:ScriptableObject
{
    public Transform _transform;

    public abstract void Init(Transform transform);
    public abstract void Rotate();

    public virtual void SetTarget(Transform transformTarget)
    {
    }
    public virtual void SetTarget(Vector2 positionTarget)
    {
    }
}
