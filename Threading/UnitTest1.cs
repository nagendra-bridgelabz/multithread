using EmployeePayrollUsingThreads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Threading
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given8Employee_WhenAddedTOList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Manish", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Reddy", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Nagendra", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Gunjan", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Dilip", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Sachin", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Mahesh", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Aniket", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Saurabh", PhoneNumber: "7760467611", Address: "xyz", Department: "HR", Gender: 'M', BasicPay: 100, Deductions: 2, TaxablePay: 20, Tax: 100, NetPay: 400, City: "Banglore", Country: "India"));

            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            DateTime startDate = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employeeDetails);
            DateTime stopDate = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDate - startDate));

            DateTime startDateThread = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateThread = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateThread - startDateThread));
        }
        //[TestMethod]
        //public void AddedMultipleEmployeeAndGetCount()
        //{
           


        //    EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
        //    employeePayrollOperations.AddEmployeeDetails();
        //    employeePayrollOperations.AddEmployeeDetailsUsingThreads();
        //    int result = employeePayrollOperations.EmployeeCount();
        //    Assert.AreEqual(2, result);
        //}
        //[TestMethod]
        //public void UpdateSalaryToMultipleEmployees()
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
        //    employeePayrollOperations.AddEmployeeDetails();
        //    stopwatch.Start();
        //    var result=employeePayrollOperations.UpdateEmployee(1);
        //    employeePayrollOperations.AddEmployeeDetailsUsingThreads();
        //    Assert.AreEqual(2000, result.BasicPay);
        //}
    }
}
