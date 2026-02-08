using UnityEngine;

public class PlayerHealth : Health
{
protected override void Die()
{
base.Die();
Debug.Log("Player died");
}
}

public class EnemyHealth : Health 
{
protected override void Die()
{
base.Die();
Debug.Log("Enemy died");
}
}
