using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Unit : MonoBehaviour
{
    [SerializeField] private int health = 600;
    [SerializeField] private int damage = 100;
    [SerializeField] private MoweBehaviour _moweBehaviour;
    [SerializeField] private RotationBehaviour _rotationBehaviour;

    private void OnEnable()
    {
        Services.Units.Add(this);
    }
    private void Update()
    {
        if(_moweBehaviour != null &&_moweBehaviour._rigidBody2D==null) InitMoweBehaviour();
        _moweBehaviour?.Mowe();

        if(_rotationBehaviour != null && _rotationBehaviour._transform==null) InitRotationBehaviour();
        _rotationBehaviour?.Rotate();
    }
    private void OnDisable()
    {
        Services.Units.Remove(this);
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
}
