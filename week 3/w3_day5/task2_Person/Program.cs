


using task2_Person;

Student st1 = new Student("ghaffr", "46microrayon");
Teacher tch1 = new Teacher("Alijon", "mardon");

st1.AddCourseGrade("IT", 5);
st1.AddCourseGrade("Bologi", 9);
st1.AddCourseGrade("hjkl;", 10);
Console.WriteLine(st1.GetAverageGrade());
System.Console.WriteLine(st1.ToString());


tch1.AddCourse("ittttt");
tch1.AddCourse("age");
tch1.AddCourse("ittttt");
Console.WriteLine(tch1.RemoveCourse("age"));
Console.WriteLine(tch1.ToString());