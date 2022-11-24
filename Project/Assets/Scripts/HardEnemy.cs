using UnityEngine;

public class HardEnemy : MonoBehaviour, IEnemy
{
    public void AttackPlayer()
    {
        Debug.Log("hard enemy attack player");
    }
}