
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MultiReverbZoneChaser : UdonSharpBehaviour
{

    [SerializeField] GameObject TargetReverbZone;
    [SerializeField] UnityEngine.Collider[] TargetColliders;
    VRCPlayerApi localPlayer;
    Vector3 closestPoint;
    float minDistance;
    Vector3 point;
    void Start()
    {
        localPlayer = Networking.LocalPlayer;
    }

    public override void PostLateUpdate()
    {
        TargetReverbZone.transform.position = FindClosestPoint(localPlayer.GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position); ;
    }
    Vector3 FindClosestPoint(Vector3 referencePosition)
    {
        minDistance = float.MaxValue;
        closestPoint = Vector3.zero;

        foreach (UnityEngine.Collider collider in TargetColliders)
        {
            point = collider.ClosestPoint(referencePosition);
            float distance = (referencePosition - point).sqrMagnitude;

            if (distance < minDistance)
            {
                minDistance = distance;
                closestPoint = point;
            }
        }

        return closestPoint;
    }
}
