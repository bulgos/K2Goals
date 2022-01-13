using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace K2Goals
{
    public class K2GoalsInfo : GH_AssemblyInfo
    {
        public override string Name => "K2Goals";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("7E456C88-CECB-45AB-B554-9960A43D1326");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}