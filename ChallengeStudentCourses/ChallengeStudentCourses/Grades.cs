using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses {
	public class Grades {
		public int CourseId { get; set; }
		public int StudentId { get; set; }
		public int Grade { get; set; }
		public List<Student> Students { get; set; }
	}
}