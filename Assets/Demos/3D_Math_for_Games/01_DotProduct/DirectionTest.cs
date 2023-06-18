using System.Collections.Generic;

using UnityEngine;

public class DirectionTest : MonoBehaviour
{
    public Transform Player;

    public List<Transform> Enemies;

    private void Start()
    {
        Test();
    }

    private void Test()
    {
        for (int i = 0; i < Enemies.Count; ++i)
        {
            Vector3 directionToEnemy = Enemies[i].position - Player.position;
            float dotProductResult = Vector3.Dot(directionToEnemy, Player.forward);

            if (dotProductResult > 0)
            {
                Debug.Log($"{Enemies[i].name} is front of Player!");
            }

            if (dotProductResult < 0)
            {
                Debug.Log($"{Enemies[i].name} is behind of Player!");
            }
        }
    }
}