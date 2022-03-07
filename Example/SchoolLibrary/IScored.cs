using System;

namespace SchoolLibrary
{
    public interface IScored
    {
        float Score { get; set; }
        float MaxScore { get; set; }
    }
}