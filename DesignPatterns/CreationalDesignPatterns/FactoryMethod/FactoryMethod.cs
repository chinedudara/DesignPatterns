using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalDesignPatterns.FactoryMethod
{

    public interface Interviewer
    {
        void AskQuestions();
    }

    public class Developer : Interviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("What are design patterns?");
        }
    }

    public class CommunityExecutive : Interviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("What are the benefits of community building?");
        }
    }

    public abstract class HiringManager
    {
        abstract protected Interviewer MakeInterviewer();

        public void TakeInterview()
        {
            var interviewer = MakeInterviewer();
            interviewer.AskQuestions();
        }
    }

    public class DevelopmentManager : HiringManager
    {
        protected override Interviewer MakeInterviewer() => new Developer();
    }

    public class MarketingManager : HiringManager
    {
        protected override Interviewer MakeInterviewer() => new CommunityExecutive();
    }
}
