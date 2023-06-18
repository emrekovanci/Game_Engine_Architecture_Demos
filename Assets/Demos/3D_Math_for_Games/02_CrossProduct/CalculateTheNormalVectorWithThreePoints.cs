using UnityEngine;

public class CalculateTheNormalVectorWithThreePoints : MonoBehaviour
{
    public Vector3 Point1;
    public Vector3 Point2;
    public Vector3 Point3;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        ///////////////////////////
        Gizmos.DrawSphere(Point1, 0.5f);
        Gizmos.DrawSphere(Point2, 0.5f);
        Gizmos.DrawSphere(Point3, 0.5f);

        ///////////////////////////
        Gizmos.DrawLine(Point1, Point2);
        Gizmos.DrawLine(Point1, Point3);
        Gizmos.DrawLine(Point2, Point3);

        ///////////////////////////
        Vector3 directionToPoint2From1 = Point2 - Point1;
        Vector3 directionToPoint3From1 = Point3 - Point1;

        ///////////////////////////
        Vector3 centerOfPoints = (Point1 + Point2 + Point3) / 3;
        Vector3 crossProductResult = Vector3.Cross(directionToPoint2From1, directionToPoint3From1);
        Vector3 normal = crossProductResult.normalized;

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(centerOfPoints, centerOfPoints + normal);
    }
}