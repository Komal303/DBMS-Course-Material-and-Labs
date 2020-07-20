﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartSchoolSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB37Entities : DbContext
    {
        public DB37Entities()
            : base("name=DB37Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActiveStatustbl> ActiveStatustbls { get; set; }
        public virtual DbSet<Adminstratortbl> Adminstratortbls { get; set; }
        public virtual DbSet<ApprovalStatustbl> ApprovalStatustbls { get; set; }
        public virtual DbSet<AttendanceMarkingtbl> AttendanceMarkingtbls { get; set; }
        public virtual DbSet<AttendanceStatustbl> AttendanceStatustbls { get; set; }
        public virtual DbSet<ClassSubjecttbl> ClassSubjecttbls { get; set; }
        public virtual DbSet<Classtbl> Classtbls { get; set; }
        public virtual DbSet<Leavestbl> Leavestbls { get; set; }
        public virtual DbSet<Markingstbl> Markingstbls { get; set; }
        public virtual DbSet<Parentstbl> Parentstbls { get; set; }
        public virtual DbSet<ParentStudenttbl> ParentStudenttbls { get; set; }
        public virtual DbSet<SchoolEventstbl> SchoolEventstbls { get; set; }
        public virtual DbSet<StudentClasstbl> StudentClasstbls { get; set; }
        public virtual DbSet<StudentLefttbl> StudentLefttbls { get; set; }
        public virtual DbSet<Studentstbl> Studentstbls { get; set; }
        public virtual DbSet<Subjectstbl> Subjectstbls { get; set; }
        public virtual DbSet<Termstbl> Termstbls { get; set; }
        public virtual DbSet<TimeTabletbl> TimeTabletbls { get; set; }
        public virtual DbSet<School_Students> School_Students { get; set; }
        public virtual DbSet<Show_Events> Show_Events { get; set; }
        public virtual DbSet<ShowAllActiveStudent> ShowAllActiveStudents { get; set; }
        public virtual DbSet<ShowAllInActiveStudent> ShowAllInActiveStudents { get; set; }
    
        public virtual ObjectResult<AllTermMarksOfAClass_Result> AllTermMarksOfAClass(Nullable<int> classid)
        {
            var classidParameter = classid.HasValue ?
                new ObjectParameter("classid", classid) :
                new ObjectParameter("classid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AllTermMarksOfAClass_Result>("AllTermMarksOfAClass", classidParameter);
        }
    
        public virtual ObjectResult<AllTermMarksOfEachStudent_Result> AllTermMarksOfEachStudent(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AllTermMarksOfEachStudent_Result>("AllTermMarksOfEachStudent", idParameter);
        }
    
        public virtual ObjectResult<AttendanceofEachStudent_Result> AttendanceofEachStudent(Nullable<int> studentid)
        {
            var studentidParameter = studentid.HasValue ?
                new ObjectParameter("studentid", studentid) :
                new ObjectParameter("studentid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AttendanceofEachStudent_Result>("AttendanceofEachStudent", studentidParameter);
        }
    
        public virtual ObjectResult<AttendanceofWholeClass_Result> AttendanceofWholeClass(Nullable<int> classid)
        {
            var classidParameter = classid.HasValue ?
                new ObjectParameter("Classid", classid) :
                new ObjectParameter("Classid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AttendanceofWholeClass_Result>("AttendanceofWholeClass", classidParameter);
        }
    
        public virtual ObjectResult<AverageOfSchool_Result> AverageOfSchool()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AverageOfSchool_Result>("AverageOfSchool");
        }
    
        public virtual ObjectResult<ShowClassWiseActiveStudents_Result> ShowClassWiseActiveStudents(Nullable<int> classid)
        {
            var classidParameter = classid.HasValue ?
                new ObjectParameter("classid", classid) :
                new ObjectParameter("classid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowClassWiseActiveStudents_Result>("ShowClassWiseActiveStudents", classidParameter);
        }
    
        public virtual ObjectResult<ShowClassWiseInActiveStudents_Result> ShowClassWiseInActiveStudents(Nullable<int> @class)
        {
            var classParameter = @class.HasValue ?
                new ObjectParameter("class", @class) :
                new ObjectParameter("class", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowClassWiseInActiveStudents_Result>("ShowClassWiseInActiveStudents", classParameter);
        }
    
        public virtual ObjectResult<ShowStudentInfo_Result> ShowStudentInfo(Nullable<int> studentid)
        {
            var studentidParameter = studentid.HasValue ?
                new ObjectParameter("studentid", studentid) :
                new ObjectParameter("studentid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ShowStudentInfo_Result>("ShowStudentInfo", studentidParameter);
        }
    
        public virtual ObjectResult<StudentsOfClass_Result> StudentsOfClass(string @class)
        {
            var classParameter = @class != null ?
                new ObjectParameter("Class", @class) :
                new ObjectParameter("Class", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StudentsOfClass_Result>("StudentsOfClass", classParameter);
        }
    
        public virtual ObjectResult<SubjectsOfStudent_Result> SubjectsOfStudent(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SubjectsOfStudent_Result>("SubjectsOfStudent", idParameter);
        }
    
        public virtual ObjectResult<SubjectWiseMarkingForEachStudent_Result> SubjectWiseMarkingForEachStudent(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SubjectWiseMarkingForEachStudent_Result>("SubjectWiseMarkingForEachStudent", studentIdParameter);
        }
    
        public virtual ObjectResult<SubjectWiseMarksForClass_Result> SubjectWiseMarksForClass(Nullable<int> classId)
        {
            var classIdParameter = classId.HasValue ?
                new ObjectParameter("ClassId", classId) :
                new ObjectParameter("ClassId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SubjectWiseMarksForClass_Result>("SubjectWiseMarksForClass", classIdParameter);
        }
    
        public virtual ObjectResult<TermWiseMarksOfAClass_Result> TermWiseMarksOfAClass(Nullable<int> classid, Nullable<int> termid)
        {
            var classidParameter = classid.HasValue ?
                new ObjectParameter("classid", classid) :
                new ObjectParameter("classid", typeof(int));
    
            var termidParameter = termid.HasValue ?
                new ObjectParameter("termid", termid) :
                new ObjectParameter("termid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TermWiseMarksOfAClass_Result>("TermWiseMarksOfAClass", classidParameter, termidParameter);
        }
    
        public virtual ObjectResult<TermWiseMarksOfEachStudent_Result> TermWiseMarksOfEachStudent(Nullable<int> id, Nullable<int> termid)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var termidParameter = termid.HasValue ?
                new ObjectParameter("termid", termid) :
                new ObjectParameter("termid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TermWiseMarksOfEachStudent_Result>("TermWiseMarksOfEachStudent", idParameter, termidParameter);
        }
    
        public virtual ObjectResult<TimeTableForEachClass_Result> TimeTableForEachClass(Nullable<int> classid)
        {
            var classidParameter = classid.HasValue ?
                new ObjectParameter("classid", classid) :
                new ObjectParameter("classid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimeTableForEachClass_Result>("TimeTableForEachClass", classidParameter);
        }
    
        public virtual ObjectResult<TotalMarksOfAllClasses_Result> TotalMarksOfAllClasses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TotalMarksOfAllClasses_Result>("TotalMarksOfAllClasses");
        }
    
        public virtual ObjectResult<TotalMarksOfEachClass_Result> TotalMarksOfEachClass(Nullable<int> classid)
        {
            var classidParameter = classid.HasValue ?
                new ObjectParameter("classid", classid) :
                new ObjectParameter("classid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TotalMarksOfEachClass_Result>("TotalMarksOfEachClass", classidParameter);
        }
    
        public virtual ObjectResult<TotalMarksOfEachStudent_Result> TotalMarksOfEachStudent(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TotalMarksOfEachStudent_Result>("TotalMarksOfEachStudent", idParameter);
        }
    }
}