using System;

namespace LinqTutorials.Models
{
    public class Emp
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public int? Deptno { get; set; }
        public Emp Mgr { get; set; }

        public override string ToString()
        {
            string managerInfo = Mgr != null ? $"Manager: {Mgr.Ename} ({Mgr.Empno})" : "No Manager";
            return $"Empno: {Empno}, Ename: {Ename}, Job: {Job}, Salary: {Salary}, HireDate: {HireDate}, Deptno: {Deptno}, {managerInfo}";
        }
    }
}