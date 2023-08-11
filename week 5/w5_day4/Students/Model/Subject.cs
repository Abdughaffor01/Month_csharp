namespace Students.Model;
public class Subject {
    int subjectId;
    string subjectName;
    int numberOfCredits;
    int courseID;
    public Subject(string subjectName, int numberOfCredits, int courseID) {
        this.subjectName = subjectName;
        this.numberOfCredits = numberOfCredits;
        this.courseID = courseID;
    }
    public int GetCourseID()=>courseID;
    public void SetCourseID(int courseID)=>this.courseID = courseID;
    public int GetSubjectId()=>subjectId;
    public void SetSubjectId(int subjectId)=>this.subjectId = subjectId;
    public string GetSubjectName()=>subjectName;
    public void SetSubjectName(string subjectName)=>this.subjectName = subjectName;
    public int GetNumberOfCredits()=>numberOfCredits;
    public void SetNumberOfCredits(int numberOfCredits)=>this.numberOfCredits = numberOfCredits;
}