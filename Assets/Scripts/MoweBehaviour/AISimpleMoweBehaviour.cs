using UnityEngine;
using System.Collections;

[CreateAssetMenu(menuName ="Behaviours/AI/Mowe/AISimpleMoweBehaviour")]
public class AISimpleMoweBehaviour : MoweBehaviour
{
    private Vector2 _moweVector;
    public override void Init(Rigidbody2D rigidbody2D)
    {
        _rigidBody2D = rigidbody2D;
        _rigidBody2D.gameObject.GetComponent<Unit>().StartCoroutine(_VectorRandomizer());
    }
    public override void Mowe()
    {
        _rigidBody2D.AddForce(_moweVector*moweSpeed);
    }
    private IEnumerator _VectorRandomizer()
    {
        while(true)
        {
            _moweVector=new Vector2(Random.Range(-1,2),Random.Range(-1,2));
            yield return new WaitForSeconds(2f);
        }
    }
}
