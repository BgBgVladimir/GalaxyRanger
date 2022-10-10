using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Unit : MonoBehaviour
{
    [SerializeField] private int health = 600;
    [SerializeField] private int damage = 100;
    public MoweBehaviour _moweBehaviour;
    public RotationBehaviour _rotationBehaviour;
    public AttackBehaviour _attackBehaviour;
    public CollisionBehaviour _collisionBehaviour;

    private void Start()
    {
        Services.Units.Add(this);
    }
    private void Update()
    {
        if(_moweBehaviour != null &&_moweBehaviour._rigidBody2D==null) InitMoweBehaviour();
        _moweBehaviour?.Mowe();

        if(_rotationBehaviour != null && _rotationBehaviour._transform==null) InitRotationBehaviour();
        _rotationBehaviour?.Rotate();

        if(_attackBehaviour!=null&&_attackBehaviour._transform==null) InitAttackBehaviour();
        _attackBehaviour?.Attack();
    }
    private void OnDisable()
    {
        Services.Units.Remove(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(_collisionBehaviour!=null&&_collisionBehaviour.unit==null) InitCollisionBehaviour();
        _collisionBehaviour?.OnCollisionEnter2D(collision);
    }

    private void InitMoweBehaviour()
    {
        _moweBehaviour=Instantiate(_moweBehaviour);
        _moweBehaviour.Init(GetComponent<Rigidbody2D>());
    }
    private void InitRotationBehaviour()
    {
        _rotationBehaviour=Instantiate(_rotationBehaviour);
        _rotationBehaviour.Init(transform);
    }
    private void InitAttackBehaviour()
    {
        _attackBehaviour=Instantiate(_attackBehaviour);
        _attackBehaviour.Init(transform);
    }
    private void InitCollisionBehaviour()
    {
        _collisionBehaviour=Instantiate(_collisionBehaviour);
        _collisionBehaviour.Init(this);
    }
}
