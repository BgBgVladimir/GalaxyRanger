using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Unit : MonoBehaviour
{
    [SerializeField] private int health = 600;
    [SerializeField] private int damage = 100;
    [SerializeField] private MoweBehaviour _moweBehaviour;


    private void Update()
    {
        if(_moweBehaviour._rigidBody2D==null) InitMoweBehaviour();

        _moweBehaviour.Mowe();
    }
    private void InitMoweBehaviour()
    {
        _moweBehaviour=Instantiate(_moweBehaviour);
        _moweBehaviour.Init(GetComponent<Rigidbody2D>());
    }
}
