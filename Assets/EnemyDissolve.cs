using UnityEngine;

public class EnemyDissolve : MonoBehaviour
{
    private Material dissolveMaterial;
    private float dissolveAmount = 0f; // Start fully visible
    private bool isDissolving = false;

    void Start()
    {
        // Get the material from the Skinned Mesh Renderer
        dissolveMaterial = GetComponentInChildren<SkinnedMeshRenderer>().material;
        dissolveMaterial.SetFloat("_Dissolve", 0f); // Start fully visible
    }

    void Update()
    {
        if (isDissolving)
        {
            dissolveAmount += Time.deltaTime / 2f; // Adjust the speed of dissolve
            dissolveMaterial.SetFloat("_Dissolve", dissolveAmount);

            if (dissolveAmount >= 1f)
            {
                Destroy(gameObject); // Remove enemy when fully dissolved
            }
        }
    }

    public void StartDissolve()
    {
        isDissolving = true;
    }
}