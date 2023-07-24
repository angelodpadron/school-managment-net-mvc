using SchoolManagmentApp.MVC.Data;

namespace SchoolManagmentApp.MVC.Models;

public class ClassEnrollmentViewModel
{
    public ClassViewModel? Class {get; set;}
    public List<StudentEnrollmentViewModel> Students {get; set;} = new List<StudentEnrollmentViewModel>();
}