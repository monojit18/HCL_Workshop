using System;

namespace SharedProject.Generic.BaseClasses
{
    public abstract class ErrorBase
    {

        public int Code { get; set; }
        public string Domain { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }

        public ErrorBase() { }
        public ErrorBase(ErrorBase error) { }

    }
}
