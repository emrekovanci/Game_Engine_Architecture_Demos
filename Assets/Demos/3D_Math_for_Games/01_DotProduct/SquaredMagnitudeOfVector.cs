using UnityEngine;

public class SquaredMagnitudeOfVector : MonoBehaviour
{
    public Vector3 Vector;

    private void Start()
    {
        Test();
    }

    private void Test()
    {
        float squaredMagnitudeWithPythagorean =
            Mathf.Pow(Vector.x, 2) +
            Mathf.Pow(Vector.y, 2) +
            Mathf.Pow(Vector.z, 2);

        float squaredMagnitudeWithDotProduct = Vector3.Dot(Vector, Vector);

        // unity also using dot-product to calculate squared magnitude
        float squaredMagnitudeWithUnity = Vector3.SqrMagnitude(Vector);

        Debug.Log($"Squared magnitude with Pythagorean Theorem: {squaredMagnitudeWithPythagorean}");
        Debug.Log($"Squared magnitude with Dot Product: {squaredMagnitudeWithDotProduct}");
        Debug.Log($"Squared magnitude with Unity: {squaredMagnitudeWithUnity}");
    }
}