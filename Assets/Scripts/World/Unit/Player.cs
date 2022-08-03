using Repositories;
using UnityEngine;
using World.Unit.Components;
using Zenject;

namespace World.Unit
{
    public class Player : MonoBehaviour
    {
        [Inject] private PlayerRepository _playerRepository;
        
        #region components

        public MoveComponent MoveComponent { get; private set; }

        #endregion

        private void Start()
        {
            _playerRepository.AddItem(this);
        }

        private void OnDestroy()
        {
            _playerRepository.RemoveItem(this);
        }
    }
}