using System.Collections.Generic;

using UnityEngine;

public class CalculateHeightOfPointAbovePlane : MonoBehaviour
{
    public List<Transform> Points;

    public Transform Plane;

    private void Start()
    {
        Test();
    }

    private void Test()
    {
        for (int i = 0; i < Points.Count; i++)
        {
            Vector3 directionToPoint = Points[i].position - Plane.position;
            Vector3 planeNormal = Plane.up;

            float dotProductResult = Vector3.Dot(planeNormal, directionToPoint);
            Debug.Log($"Distance between {Points[i].name} and Plane: {dotProductResult}");
        }
    }
}