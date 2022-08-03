using World.Unit.Components;

namespace World.Skills
{
    public interface ISkill
    {
        float GetCastingTime();
        void ApplySkill(SkillReceiverComponent unitComponent);
    }
}