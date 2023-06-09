using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{

    // The target that we're going to be focusing on
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        // Calculate the relative position between gameObject and the target
        Vector3 relativePos = target.position - transform.position;

        // Project the relativeposition onto the XZ plane to rotate the UFO around it's Y axis
        Vector3 relativePosXZ = Vector3.ProjectOnPlane(relativePos, Vector3.up);

        // Create a look rotation to rotate UFO in the direction of relative direction
        Quaternion lookRot = Quaternion.LookRotation(relativePosXZ);

        // Apply rotation to gameObject
        transform.rotation = lookRot;
    }
}
