﻿namespace Data.Models.SkillEngine
{
    public class Skill
    {
        public int Id { get; set; }
        public int Force { get; set; }
        public int Job { get; set; }
        public int JobLevel { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; }
        public int ManaCost { get; set; }
        public int LearnExp { get; set; }
        public int Attack { get; set; }
        public int Type { get; set; }
        public int Effect { get; set; }
        public int Index { get; set; }
        public int AttackCount { get; set; }
        public int Time { get; set; }

        private static readonly Skill NullTemplate = new Skill();

        public static Skill Factory(int id)
        {
            //return !Data.SkillTemplates.ContainsKey(id) ? NullTemplate : Data.SkillTemplates[id];
            return NullTemplate;
        }
    }
}
