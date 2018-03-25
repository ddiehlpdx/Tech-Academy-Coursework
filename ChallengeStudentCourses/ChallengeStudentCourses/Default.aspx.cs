using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */ 
			 resultLabel.Text = "";

			 List<Course> courses = new List<Course>() {
				new Course() { 
					CourseId = 1, Name = "Sarcasm 101", Students = new List<Student>() {
						new Student() { StudentId = 1, Name = "Tobias Funke" },
						new Student() { StudentId = 2, Name = "Gene Parmesan" }}
					},
				new Course() { 
					CourseId = 2, Name = "Indifference 435", Students = new List<Student>() {
						new Student() { StudentId = 3, Name = "Lucille Ostero" },
						new Student() { StudentId = 4, Name = "Ann Veal" }}
				},
				new Course() { 
					CourseId = 3, Name = "Creative Insults 300", Students = new List<Student>() {
						new Student() { StudentId = 5, Name = "J. Walter Weatherman" },
						new Student() { StudentId = 6, Name = "Bob Lobla" }}
				}
			 };

			foreach (var course in courses) {
				resultLabel.Text += course.CourseId.ToString() + " : " + course.Name.ToString() + "<br />";
				foreach (var student in course.Students) {
					resultLabel.Text += "-" + student.Name + "<br />";
				}
			}

        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */ 
			 resultLabel.Text = "";

			 Dictionary<int, Student> students = new Dictionary<int, Student>() {
				{ 1, new Student() { 
					Name = "Tobias Funke", StudentId = 1, Courses = new List<Course>() {
						new Course() { CourseId = 1, Name = "Sarcasm 101" }, 
						new Course() { CourseId = 2, Name = "Indifference 435" }}
					}
				},
				{ 2, new Student() { 
					Name = "Gene Parmesan", StudentId = 2, Courses = new List<Course>() {
						new Course() { CourseId = 3, Name = "Creative Insults 300" },
						new Course() { CourseId = 1, Name = "Sarcasm 101" }}
					}
				},
				{ 3, new Student() { 
					Name = "Stan Sitwell", StudentId = 3, Courses = new List<Course>() {
					new Course() { CourseId = 2, Name = "Indifference 435" }, 
					new Course() { CourseId = 3, Name = "Creative Insults 300" }}
					}
				}
			 };

			foreach (var student in students.Values) {
				resultLabel.Text += student.StudentId.ToString() + " : " + student.Name.ToString() + "<br />";
				foreach (var course in student.Courses) {
					resultLabel.Text += "-" + course.Name.ToString() + "<br />";
				}
			}

        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */ 
			 resultLabel.Text = "";
			 
			 List<Student> grades = new List<Student>() {
				new Student() {
					Name = "Tobias Funke", StudentId = 1, Courses = new List<Course>() {
						new Course() { CourseId = 1, Name = "Sarcasm 101", Grade = 78 },
						new Course() { CourseId = 2, Name = "Indifference 435", Grade = 82 }}
					},
				new Student() {
					Name = "Gene Parmesan", StudentId = 2, Courses = new List<Course>() {
						new Course() { CourseId = 3, Name = "Creative Insults 300", Grade = 94 },
						new Course() { CourseId = 1, Name = "Sarcasm 101", Grade = 90 }}
					},
				new Student() {
					Name = "Stan Sitwell", StudentId = 3, Courses = new List<Course>() {
					new Course() { CourseId = 2, Name = "Indifference 435", Grade = 77 },
					new Course() { CourseId = 3, Name = "Creative Insults 300", Grade = 89 }}
				}
				};

			foreach (var student in grades) {
				resultLabel.Text += student.Name + "<br />";
				foreach (var course in student.Courses) {
					resultLabel.Text += "-" + course.Name + " : " + course.Grade + "%" + "<br />";
				}
			}

        }
    }
}