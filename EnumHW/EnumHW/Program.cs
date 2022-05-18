using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HelpDeskCalls> calls = new List<HelpDeskCalls>()
            {
                new HelpDeskCalls { DescriptionOfProblem = "Password reset", DateReported = "2/20/21", Status = Status.NotStarted, Priority = Priority.Low, ReportedBy = "Ted Lasso", Notes = "" },
                new HelpDeskCalls { DescriptionOfProblem = "Download zoom", DateReported = "2/19/21", Status = Status.InProg, Priority = Priority.Medium, ReportedBy = "Jamie Tart", Notes = "" },
                new HelpDeskCalls { DescriptionOfProblem = "Computer will not turn on", DateReported = "2/20/21", Status = Status.Unresolved, Priority = Priority.High, ReportedBy = "Ted Mosby", Notes = "" },
                new HelpDeskCalls { DescriptionOfProblem = "Setting up Outlook", DateReported = "2/18/21", Status = Status.Completed, Priority = Priority.Low, ReportedBy = "Barney Stinson", Notes = "" },
                new HelpDeskCalls { DescriptionOfProblem = "Virus on computer", DateReported = "2/15/21", Status = Status.InProg, Priority = Priority.High, ReportedBy = "Dwight Schrute", Notes = "" },
            }; 

            // #3 
            foreach (var calls1 in calls)
            {
                switch (calls1.Status)
                {
                    case Status.NotStarted:
                        calls1.Notes = "Just Reported";
                        break;
                    case Status.InProg:
                        calls1.Notes = "Help Desk personnel on scene";
                        break;
                    case Status.Completed:
                        calls1.Notes = "Ticket is complete";
                        break;
                    case Status.Unresolved:
                        calls1.Notes = "Ongoing investigation";
                        break;
                } // end switch

                Console.WriteLine("Problem: " + calls1.DescriptionOfProblem + "\nDate Reported: " + calls1.DateReported + "\nStatus: " + calls1.Status + "\nPriority: " + calls1.Priority + "\nReported by: " + calls1.ReportedBy + "\nNotes: " + calls1.Notes);

                // Pause
                Console.ReadLine();

            } // end foreach


            // #4
            foreach (var calls2 in calls)
            {
                switch (calls2.Priority)
                {
                    case Priority.Low:
                        Console.WriteLine(calls2.DescriptionOfProblem + "\nThe problem is on the back-burner.");
                        break;
                    case Priority.Medium:
                        Console.WriteLine(calls2.DescriptionOfProblem + "\nThe problem is important.");
                        break;
                    case Priority.High:
                        Console.WriteLine(calls2.DescriptionOfProblem + "\nThe problem is critical.");
                        break;
                } // end switch

                // Pause
                Console.ReadLine();

            } // end foreach

        } // end Main

    } // end class Program

    class HelpDeskCalls
    {
        public string DescriptionOfProblem { get; set; }
        public string DateReported { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public string ReportedBy { get; set; }
        public string Notes { get; set; }
    } // end class HelpDeskCalls

    enum Status
    {
        NotStarted,
        InProg,
        Completed,
        Unresolved,
    } // end enum Status

    enum Priority
    {
        Low,
        Medium,
        High
    } // end enum Priority

} // end namespace
