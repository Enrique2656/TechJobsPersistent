using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public int SkillId { get; set; }
        public List<SelectListItem> Skills { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();

            foreach (var e in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Name
                });
            }

            Skills = new List<SelectListItem>();

            foreach (var s in skills)
            {
                Skills.Add(new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                });
            }
        }

        public AddJobViewModel()
        {

        }
    }
}
