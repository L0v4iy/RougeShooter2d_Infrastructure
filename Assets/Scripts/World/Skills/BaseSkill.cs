using World.Unit.Components;

namespace World.Skills
{
    public abstract class BaseSkill : ISkill
    {
        public abstract float GetCastingTime();

        public abstract void ApplySkill(SkillReceiverComponent unitComponent);
    }
}