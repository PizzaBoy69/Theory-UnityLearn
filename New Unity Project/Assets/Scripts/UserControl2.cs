using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl2 : MonoBehaviour
{
    [SerializeField] private string selectableTag = "selectableTag"; // ENCAPSULATION
    [SerializeField] private Material highlightMaterial; // ENCAPSULATION
    private Material originalMaterial;

    public static bool isSelected { get; private set; } // ENCAPSULATION
    public static string selectedName { get; private set; } // ENCAPSULATION
    private Transform _selection;

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleSelection();
    }

    public void HandleSelection()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = originalMaterial;
            _selection = null;
            isSelected = false;
        }
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {
                    originalMaterial = selectionRenderer.material;
                    selectionRenderer.material = highlightMaterial;
                }
                _selection = selection;
                isSelected = true;
                selectedName = hit.collider.name;
            }
            Debug.DrawLine(ray.origin, hit.point);
        }
    }
}
