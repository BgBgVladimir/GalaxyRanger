using UnityEngine;

public abstract class AttackBehaviour:ScriptableObject
{
    public Transform _transform;
    public GameObject shotPrefab;

    public abstract void Init(Transform transform);
    public abstract void Attack();
}
