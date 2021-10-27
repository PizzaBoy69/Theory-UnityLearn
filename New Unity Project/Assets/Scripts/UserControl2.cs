using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl2 : MonoBehaviour
{
    [SerializeField] private string selectableTag = "selectableTag";
    [SerializeField] private Material highlightMaterial;
    private Material originalMaterial;
    public string objectName; 

    private Transform _selection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
                objectName = selection.name;
            }
            Debug.DrawLine(ray.origin, hit.point);
        }
    }
}
