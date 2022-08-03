using System.Collections.Generic;
using UnityEngine;
using World.Control;
using World.Skills;
using Zenject;

namespace World.Unit.Components
{
    /// <summary>
    /// Receive skill to apply 
    /// </summary>
    public class SkillReceiverComponent : MonoBehaviour
    {
        private readonly Dictionary<ISkill, float> _castingJournal = new Dictionary<ISkill, float>();

        public void AttemptToCastSkill(ISkill skill)
        {
            if (SkillIsReloaded(skill))
            {
                CastSkill(skill);
            }
        }

        private void CastSkill(ISkill skill)
        {
            skill.ApplySkill(this);
            _castingJournal[skill] = Time.time + skill.GetCastingTime();
        }

        private bool SkillIsReloaded(ISkill skill)
        {
            if (!_castingJournal.ContainsKey(skill))
                _castingJournal[skill] = 0f;

            return _castingJournal[skill] > Time.time;
        }
    }
}