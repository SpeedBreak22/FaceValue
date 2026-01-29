using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform FollowTarget, LookTarget;
    public float FollowSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = FollowTarget.position;
        transform.position = Vector3.Lerp(transform.position,targetPosition,FollowSpeed*Time.deltaTime);

        transform.LookAt(LookTarget);
    }
}
