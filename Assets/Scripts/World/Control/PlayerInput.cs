using System;
using System.Collections.Generic;
using Repositories;
using UnityEngine;
using World.Skills;
using World.Unit.Components;
using Zenject;

namespace World.Control
{
    public class PlayerInput : MonoBehaviour
    {
        #region inject

        [Inject] private PlayerRepository _playerRepository;

        #endregion


        private readonly PlayerInputActions _actions = new PlayerInputActions();
        private readonly SkillController _skillController = new SkillController();

        private Vector2 MoveDirection => _actions.Player.Move.ReadValue<Vector2>();

        private void Awake()
        {
            _actions.Enable();
            _actions.Player.Move.performed += context => MovePlayer(MoveDirection);

            _actions.Skills.Skill0.performed += context => CastSkill(0);
            _actions.Skills.Skill1.performed += context => CastSkill(1);
            _actions.Skills.Skill2.performed += context => CastSkill(2);
            _actions.Skills.Skill3.performed += context => CastSkill(3);
            _actions.Skills.Skill4.performed += context => CastSkill(4);
            _actions.Skills.Skill5.performed += context => CastSkill(5);
        }

        private void OnDestroy()
        {
            _actions.Disable();
            _actions.Dispose();
        }

        private void MovePlayer(Vector2 direction)
        {
            _playerRepository.GetPlayer().MoveComponent.Move(direction);
            
        }

        private void CastSkill(int skillPosition)
        {
            ISkill skill = _skillController.GetPressedSkill(skillPosition);
            _playerRepository.GetPlayer().GetComponent<SkillReceiverComponent>().AttemptToCastSkill(skill);
        }
    }
}