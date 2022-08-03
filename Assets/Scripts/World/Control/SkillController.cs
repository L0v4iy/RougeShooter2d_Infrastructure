using System;
using World.Skills;

namespace World.Control
{
    /// <summary>
    /// Handles skills from skill board
    /// </summary>
    public class SkillController
    {
        private readonly SkillBoard _skillBoard = new SkillBoard();

        public ISkill GetPressedSkill(int skillPosition)
        {
            return _skillBoard.CompareSkillByBoardPosition(skillPosition);
        }
    }

    internal class SkillBoard
    {
        //TODO:2022-05-03 11:43:09 Crutch here, refactor this later

        internal ISkill CompareSkillByBoardPosition(int position)
        {
            switch (position)
            {
                case 0:
                    throw new NotImplementedException();
                case 1:
                    throw new NotImplementedException();
                case 2:
                    throw new NotImplementedException();
                case 3:
                    throw new NotImplementedException();
                case 4:
                    throw new NotImplementedException();
                case 5:
                    throw new NotImplementedException();
                default:
                    throw new NotImplementedException();
            }
        }

    }
}