using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace CustomGoals
{
    public class CustomGoalsInfo : GH_AssemblyInfo
    {
        public override string Name => "CustomGoals";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("4D67E0BC-9E1E-4C30-948C-E76DB2724213");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}