using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy 
{
    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = 12f;
    }

    protected override void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
        if (!isRecoiling)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(playerController.Instance.transform.position.x, transform.position.y), Speed * Time.deltaTime);
        }
    }
    public override void EnemyHit(float _damageDone, Vector2 _hitDirection, float _hitForce)
    {
        base.EnemyHit( _damageDone,  _hitDirection, _hitForce);
    }
}
