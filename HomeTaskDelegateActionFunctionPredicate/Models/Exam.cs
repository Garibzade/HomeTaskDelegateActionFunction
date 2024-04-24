using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskDelegateActionFunctionPredicate.Models
{
    internal class Exam
    {
        public Exam(string subject,int examduration,DateTime start)
        {
				_examDuration = examduration;
				_subject = subject;
			   StartDate= start;
            EndDate = start.AddMinutes(examduration);

        }
        private string _subject;

		public string Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}
		private int _examDuration;

        public int ExamDuration
        {
			get { return _examDuration; }
			set { _examDuration = value; }
		}
		public DateTime StartDate { get;set; }
		public DateTime EndDate {
           get;set;
        }

		public void  Start()
		{ StartDate = DateTime.Now; }

	}
}
