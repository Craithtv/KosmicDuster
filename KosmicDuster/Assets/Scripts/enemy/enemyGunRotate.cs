using UnityEngine;

public class enemyGunRotate : MonoBehaviour
{
    private Transform parentTransform;

    void Start()
    {
        // Get the parent's transform
        parentTransform = transform.parent;
        
        if (parentTransform == null)
        {
            Debug.LogError("RotateWithParent script requires a parent object.");
        }
    }

    void LateUpdate()
    {
        // Update the rotation to match the parent's rotation
        transform.rotation = parentTransform.rotation;
    }
}

