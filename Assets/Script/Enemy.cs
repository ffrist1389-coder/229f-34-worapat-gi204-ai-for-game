using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Enemy : MonoBehaviour
{
    public float moveSpeed = 6f;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = (transform.right * x + transform.forward * z).normalized;
        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}
