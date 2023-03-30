using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(ModelVariants))]
public class MaterialManager : MonoBehaviour
{
    private Renderer _renderer;

    public void SetMaterial(Material material) {
        
        _renderer = GetComponent<ModelVariants>().GetCurrentSelected().GetComponent<Renderer>();
        _renderer.material = material;
    }

}
