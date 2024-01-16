using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class disappear : MonoBehaviour
{
    public GameObject targetObject;
    [SerializeField]
    InputAction click = new InputAction(type: InputActionType.Button);
    private bool isVisible = true; 

    void OnEnable()
    {
        click.Enable();
    }

    void OnDisable()
    {
        click.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (click.triggered)
        {
            isVisible = !isVisible;
            targetObject.SetActive(isVisible);
        }
    }
}
