using UnityEngine;

namespace World.Unit.Components
{
    public class MoveComponent : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private Rigidbody2D body;

        public void Move(Vector2 direction)
        {
            body.AddForce(direction * speed);
        }
    }
}