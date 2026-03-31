using Unity.VisualScripting;
using UnityEngine;

public class Lost : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy (gameObject, 5f);
    }


    void Update()
    {
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
    
}
