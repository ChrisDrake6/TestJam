using UnityEngine;

public class FollowCamera : MonoBehaviour
{    
    // Wie stark ist die Bewegung gedämpft
    public float SmoothTime = 0.25f;

    // Abstand zum Zielobjekt    
    private Vector3 Offset;

    // Diesem GameObject bzw. Transform wird gefolgt
    private Transform Target;

    // Geschwindigkeit mit der sich die Kamera gerade bewegt
    private Vector3 _velocity;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - Target.position;
        
    }

    void LateUpdate()
    {
        Vector3 targetPosition = Target.position + Offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, SmoothTime);
        transform.position = smoothedPosition;            
    }
}
