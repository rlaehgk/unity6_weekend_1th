using JetBrains.Annotations;
using UnityEngine;

public class turtle : MonoBehaviour
{
    public float speed = 5f;
    public int direction = 1;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position = transform.position + new Vector3(direction, 0, 0) * speed * Time.deltaTime;
    }
}
