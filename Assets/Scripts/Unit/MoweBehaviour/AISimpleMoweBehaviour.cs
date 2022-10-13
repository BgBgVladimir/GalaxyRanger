using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName ="Behaviours/AI/Mowe/AISimpleMoweBehaviour")]
public class AISimpleMoweBehaviour : MoweBehaviour
{
    private Vector2 _moweVector;
    public override void Init(Unit _unit)
    {
        unit=_unit;
        rigidBody2D=_unit.GetComponent<Rigidbody2D>();
        unit.StartCoroutine(_VectorRandomizer());
    }
    public override void Update()
    {
        rigidBody2D.AddForce(_moweVector*moweSpeed);
    }
    public IEnumerator _VectorRandomizer()
    {
        while(true)
        {
            _moweVector=new Vector2(Random.Range(-1,2),Random.Range(-1,2));
            yield return new WaitForSeconds(2f);
        }
    }
}
