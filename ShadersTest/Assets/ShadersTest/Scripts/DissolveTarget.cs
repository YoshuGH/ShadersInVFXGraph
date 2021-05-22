using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]
public class DissolveTarget : MonoBehaviour
{
    public Transform objToTrack = null;

    private Material matRef = null;
    private new Renderer renderer = null;

    public Renderer Renderer
    {
        get
        {
            if(renderer == null)
            {
                renderer = this.GetComponent<Renderer>();
            }

            return renderer;
        }
    }

    public Material MaterialRef
    {
        get
        {
            if (matRef == null)
            {
                matRef = Renderer.material;
            }

            return matRef;
        }
    }

    private void Awake()
    {
        renderer = this.GetComponent<Renderer>();
        matRef = renderer.material;
    }

    private void Update()
    {
        if(objToTrack != null)
        {
            MaterialRef.SetVector("_pos", objToTrack.position);
        }
    }

    private void OnDestroy()
    {
        renderer = null;
        if (matRef != null)
            Destroy(matRef);

        matRef = null;
    }
}
