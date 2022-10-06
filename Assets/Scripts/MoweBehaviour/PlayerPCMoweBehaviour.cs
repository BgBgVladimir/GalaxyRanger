using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName ="Behaviours/Player/Mowe/PlayerPCMoweBehaviour")]
public class PlayerPCMoweBehaviour: MoweBehaviour
{
    public override void Init(Rigidbody2D rigidbody2D)
    {
        _rigidBody2D = rigidbody2D;
    }
    public override void Mowe()
    {
        if(Input.GetKey(KeyCode.W))
        {
            addForce(Vector2.up);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            addForce(Vector2.down);
        }
        if(Input.GetKey(KeyCode.A))
        {
            addForce(Vector2.left);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            addForce(Vector2.right);
        }

    }
    private void addForce(Vector2 _moweVector)
    {
        _rigidBody2D.AddForce(_moweVector*moweSpeed);
    }
}
