using UnityEngine;
using System.Collections;

public static class ExtensionMethods {
    public static void SetPosX(this Transform trans, float value)
    {
        Vector3 pos = trans.position;
        trans.position = new Vector3(value, trans.position.y, trans.position.z);
    }
    public static void SetPosY(this Transform trans, float value)
    {
        Vector3 pos = trans.position;
        trans.position = new Vector3(trans.position.x, value, trans.position.z);
    }
    public static void SetPosZ(this Transform trans, float value)
    {
        Vector3 pos = trans.position;
        trans.position = new Vector3(trans.position.x, trans.position.y, value);
    }


    public static T GetComponentInHierarchy<T>(this GameObject go)
    {
        if (go.GetComponent<T>() != null)
            return go.GetComponent<T>();
        else if (go.transform.GetComponentInChildren<T>() != null)
            return go.transform.GetComponentInChildren<T>();
        else if (go.transform.GetComponentInParent<T>() != null)
            return go.transform.GetComponentInParent<T>();

        return default(T);
    }
    public static T GetComponentInHierarchy<T>(this Component co)
    {
        if (co.GetComponent<T>() != null)
            return co.GetComponent<T>();
        else if (co.transform.GetComponentInChildren<T>() != null)
            return co.transform.GetComponentInChildren<T>();
        else if (co.transform.GetComponentInParent<T>() != null)
            return co.transform.GetComponentInParent<T>();

        return default(T);
    }
}