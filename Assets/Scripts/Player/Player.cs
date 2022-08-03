using UnityEngine;


namespace Player
{
    //TODO:2022-05-02 18:34:13 Refactor this 
    /// <@see cref="World.Unit.Player">
    public class Player : MonoBehaviour
    {
        public float Health = 10f;


        void Start()
        {
            //transform.position = Random.insideUnitCircle * 3;   
        }

        void Update()
        {
        }

        public void TakeDamage(float damage)
        {
            Health -= damage;
        }
    }
}