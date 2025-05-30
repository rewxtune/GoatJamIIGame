using UnityEngine;

public class CameraFollowWithDeadzone : MonoBehaviour
{
    public Transform target;           // The player
    public float smoothTime = 0.3f;    // Smoothness of camera movement

    public Vector2 deadzoneSize = new Vector2(1f, 0.56f); // Width & height of deadzone rectangle around camera center

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 cameraPos = transform.position;
        Vector3 targetPos = target.position;
        targetPos.z = cameraPos.z; // Keep camera Z

        // Calculate difference between target and camera
        Vector3 diff = targetPos - cameraPos;

        Vector3 move = Vector3.zero;

        // Check X axis: only move camera if target is outside deadzone on X
        if (Mathf.Abs(diff.x) > deadzoneSize.x / 2)
        {
            move.x = diff.x - Mathf.Sign(diff.x) * deadzoneSize.x / 2;
        }

        // Check Y axis: only move camera if target is outside deadzone on Y
        if (Mathf.Abs(diff.y) > deadzoneSize.y / 2)
        {
            move.y = diff.y - Mathf.Sign(diff.y) * deadzoneSize.y / 2;
        }

        Vector3 targetCameraPos = cameraPos + move;

        // Smoothly move camera
        transform.position = Vector3.SmoothDamp(cameraPos, targetCameraPos, ref velocity, smoothTime);
    }

    // Optional: visualize the deadzone in editor
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, new Vector3(deadzoneSize.x, deadzoneSize.y, 0));
    }
}