using Grasshopper.Kernel;
using Rhino.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KangarooGoals
{
    public class SimpleGoalComponent : GH_Component
    {
        public SimpleGoalComponent()
            : base("Simple Goal", "SimpG", "Constructs a simple Goal",
                  "Custom Goals", "test")
        { }

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddPointParameter("Points", "P", "The points for the goal to act on", GH_ParamAccess.item);
            pManager.AddGeometryParameter("Collision object", "C", "Geometry Object for Collisions", GH_ParamAccess.item);
            pManager.AddNumberParameter("Strength", "k", "Strength", GH_ParamAccess.item, 1);

            pManager[1].Optional = true;
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddGenericParameter("Scripted Goal", "G", "Scripted Goal", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            Point3d point = Point3d.Unset;
            GeometryBase geometry = null;
            double strength = double.NaN;

            DA.GetData(0, ref point);
            DA.GetData(1, ref geometry);
            DA.GetData(2, ref strength);

            var simpleGoal = new SimpleGoal(point, strength);

            DA.SetData(0, simpleGoal);
        }

        public override Guid ComponentGuid => new Guid("0d56e81b-925b-4548-9545-d41a8a160acc");
    }
}
