using UnityEngine;

public class MediumEnemy : MonoBehaviour, IEnemy
{
    public void AttackPlayer()
    {
        Debug.Log("Medium enemy attack player");
    }
}