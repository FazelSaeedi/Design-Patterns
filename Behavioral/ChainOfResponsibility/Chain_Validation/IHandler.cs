using System;
using System.Collections.Generic;

namespace Design_Patterns.Behavioral.ChainOfResponsibility.Chain_Validation
{
    public interface IHandler
    {
        void SetNextHandler(IHandler handler);
        void Process(Request request);
    }

    public class BaseHandler : IHandler
    {
        protected IHandler _nextHandler;

        public BaseHandler()
        {
            _nextHandler = null;
        }

        public virtual void Process(Request request)
        {
            throw new System.Exception();
        }

        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }
    }

    public class Request
    {
        public object Data { get; set ;}
        public List<string> ValidationMessages ;

        public Request()
        {
            ValidationMessages = new List<string>();
        }

    }
    

    public class Person
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public float Income {get; set;}
    }


    public class MaxAgeHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is Person person)
            {
                if(person.Age > 55 ) 
                    request.ValidationMessages.Add("Invalid Age");
                if(_nextHandler != null) 
                    _nextHandler.Process(request);
            }
            else
            {
                throw new Exception("Invalid");
            }
            //base.Process(request);
        }
    }

    public class MaxNameLenghtHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is Person person)
            {
                if(person.Name.Length > 55 ) 
                    request.ValidationMessages.Add("Invalid Name Lenght");
                if(_nextHandler != null) 
                    _nextHandler.Process(request);
            }
            else
            {
                throw new Exception("Invalid");
            }
            //base.Process(request);
        }
    }

    public class MaxIncomeLenghtHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is Person person)
            {
                if(person.Income > 55 ) 
                    request.ValidationMessages.Add("Invalid Income ");
                if(_nextHandler != null) 
                    _nextHandler.Process(request);
            }
            else
            {
                throw new Exception("Invalid");
            }
            //base.Process(request);
        }
    }
}