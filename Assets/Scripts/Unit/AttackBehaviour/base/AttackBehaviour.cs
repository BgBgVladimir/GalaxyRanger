using UnityEngine;

public abstract class AttackBehaviour:ScriptableBehaviour
{
    public Transform _transform;
    public GameObject shotPrefab;

    public override void Init(Unit _unit)
    {

    }
    public abstract void Attack();
}
