using UnityEngine;

public static class  UnityGetID
{
#if UNITY_6000_4_OR_NEWER
    public static EntityId GetID(this Object obj)
        => obj.GetEntityId();
#else
    public static EntityId GetID(this Object obj)
        => obj.GetInstanceID();
#endif
}
