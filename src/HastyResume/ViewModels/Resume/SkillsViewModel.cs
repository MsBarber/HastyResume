using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HastyResume.ViewModels.Resume
{
    public class SkillsViewModel
    {

        [DataType(DataType.Text)]
        public string Skill1_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkill1Name { get; set; }
        public int Skill1_ChildSkill1Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkill2Name { get; set; }
        public int Skill1_ChildSkill2Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill1_ChildSkill3Name { get; set; }
        public int Skill1_ChildSkill3Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkill1Name { get; set; }
        public int Skill2_ChildSkill1Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkill2Name { get; set; }
        public int Skill2_ChildSkill2Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill2_ChildSkill3Name { get; set; }
        public int Skill2_ChildSkill3Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ParentSkill { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkill1Name { get; set; }
        public int Skill3_ChildSkill1Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkill2Name { get; set; }
        public int Skill3_ChildSkill2Percent { get; set; }
        [DataType(DataType.Text)]
        public string Skill3_ChildSkill3Name { get; set; }
        public int Skill3_ChildSkill3Percent { get; set; }
    }
}
