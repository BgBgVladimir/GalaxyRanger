using UnityEngine;

[CreateAssetMenu(menuName = "Behaviours/AI/Mowe/AIAggressiveMoweToTargetBehaviour")]
public class AIAggressiveMoweToTargetBehaviour: MoweBehaviour
{
    private Vector2 _moweVector;

    [SerializeField] private Transform _target;
    public override void Init(Unit _unit)
    {
        unit=_unit;
        rigidBody2D=_unit.GetComponent<Rigidbody2D>();
    }
    public override void Update()
    {
        if(_target==null)
        {
            return;
        }
        _moweVector =_target.position-rigidBody2D.transform.position;
        rigidBody2D.AddForce(_moweVector.normalized*moweSpeed);
    }
    public override void SetTarget(Transform target)
    {
        _target=target;
    }
}
