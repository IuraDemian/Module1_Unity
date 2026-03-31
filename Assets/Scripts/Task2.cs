using UnityEngine;

public class Module1 : MonoBehaviour
{

    void Start()
    {
        Vector3 a = new Vector3(1, 5, -7);
        Vector3 b = new Vector3(8, 0, -6);

        // Знаходимо кут у градусах
        float angle = Vector3.Angle(a, b);

        Debug.Log("Кут між векторами: " + angle + " градусів");
    }

    void Update()
    {
        
    }

}
