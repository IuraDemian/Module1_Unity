using UnityEngine;

public class Module1 : MonoBehaviour
{

    void Start()
    {
        Vector3 a = new Vector3(1, 5, -7);
        Vector3 b = new Vector3(8, 0, -6);

        float distance = Vector3.Distance(a, b);

        Debug.Log("Відстань: " + distance);
    }

    void Update()
    {
        
    }

}
