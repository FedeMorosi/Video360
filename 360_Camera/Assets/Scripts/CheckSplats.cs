using GaussianSplatting.Runtime;
using UnityEngine;
public class CheckSplats : MonoBehaviour
{
    public GameObject rendererComponent;
    void Start()
    {
        Debug.Log("Point count: " + rendererComponent.GetComponent<GaussianSplatRenderer>().splatCount);
    }
}