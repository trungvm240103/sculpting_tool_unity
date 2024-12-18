using UnityEngine;

public class ShapeCreator : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject cylinderPrefab;
    public GameObject capsulePrefab;
    public GameObject planePrefab;
    // Method to create a new cube
    public void CreateCube()
    {
        Debug.Log("Creating Cube");
        Instantiate(cubePrefab, new Vector3(0, 1, 0), Quaternion.identity);
    }

    public void CreateSphere()
    {
        Debug.Log("Creating Sphere");
        Instantiate(spherePrefab, new Vector3(0, 1, 0), Quaternion.identity);
    }

    public void CreateCylinder()
    {
        Debug.Log("Creating Cylinder");
        Instantiate(cylinderPrefab, new Vector3(0, 1, 0), Quaternion.identity);
    }

    public void CreateCapsule ()
    {
        Debug.Log("Creating Capsule");
        Instantiate(capsulePrefab, new Vector3(0, 1, 0), Quaternion.identity);
    }

    public void CreatePlane()
    {
        Debug.Log("Creating Plane");
        Instantiate(planePrefab, new Vector3(0, 1, 0), Quaternion.identity);
    }
}
