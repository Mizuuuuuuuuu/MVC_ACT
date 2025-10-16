using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_ACT.Models
{
    // About View Model
    public class AboutViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }

    // Contact View Model
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [MinLength(10, ErrorMessage = "Message must be at least 10 characters")]
        public string Message { get; set; }
    }

    // Education View Model
    public class EducationViewModel
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string Year { get; set; }
        public string Description { get; set; }
    }

    // Experience View Model
    public class ExperienceViewModel
    {
        public string Position { get; set; }
        public string Company { get; set; }
        public string Period { get; set; }
        public string Description { get; set; }
        public List<string> Responsibilities { get; set; }
    }

    // Gallery View Model
    public class GalleryViewModel
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }

    // Hobby View Model
    public class HobbyViewModel
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }

    // Project View Model
    public class ProjectViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public string GithubUrl { get; set; }
        public string LiveUrl { get; set; }
    }

    // Resume View Model
    public class ResumeViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public List<string> Skills { get; set; }
        public List<ExperienceViewModel> Experiences { get; set; }
        public List<EducationViewModel> Educations { get; set; }
    }

    // Skill View Model
    public class SkillViewModel
    {
        public string Name { get; set; }
        public int Level { get; set; } // 0-100
    }

    // Skill Category View Model
    public class SkillCategoryViewModel
    {
        public string Category { get; set; }
        public List<SkillViewModel> Skills { get; set; }
    }

    // Error View Model (from Visual Studio template)
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}